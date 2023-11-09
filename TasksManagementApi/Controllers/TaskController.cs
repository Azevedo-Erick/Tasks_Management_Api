using Microsoft.AspNetCore.Mvc;
using TasksManagementApi.Data;
using TasksManagementApi.Dtos;
using TasksManagementApi.Models;
using Task = TasksManagementApi.Models.Task;

namespace TasksManagementApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ApplicationContext _context;

    public TaskController(ApplicationContext context)
    {
        _context = context;
    }
    
    
    [HttpGet]
    public IActionResult Get()
    {
        return  Ok(_context.Tasks.ToList());
    }
    
    [HttpGet("{id:int}")]
    public  IActionResult GetById([FromRoute] int id)
    {
        return Ok(_context.Tasks.FirstOrDefault(x => x.Id == id));
    }
    
    [HttpPost]
    public IActionResult Create([FromBody] RequestTaskDto data)
    {
        var domainData = new Task
        {
            Description = data.Description,
            StartDate = data.StartDate,
            Name = data.Name,
            DeadLine = data.DeadLine,
            Priority = data.Priority,
            Status = StatusTask.Média
            //Status = data.Status,
        };
        _context.Tasks.Add(domainData);
        _context.SaveChanges();
        return Ok(domainData);

    }
    
    [HttpPatch("{id:int}")]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskDto data)
    {
        var domainData = _context.Tasks.FirstOrDefault(x => x.Id == id) ?? throw new Exception();

        domainData.Description = data.Description;
        domainData.StartDate = data.StartDate;
        domainData.Name = data.Name;
        domainData.DeadLine = data.DeadLine;
        domainData.Priority = data.Priority;
        domainData.Status = data.Status;

        _context.Tasks.Update(domainData);
        _context.SaveChanges();
        return Ok(domainData);
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var domainData = _context.Tasks.FirstOrDefault(x => x.Id == id) ?? throw new Exception();
        _context.Tasks.Remove(domainData);
        _context.SaveChanges();
        return Ok();
    }
}