using Microsoft.AspNetCore.Mvc;
using TasksManagementApi.Data;
using TasksManagementApi.Dtos;
using TasksManagementApi.Dtos.Response;
using TasksManagementApi.Models;
using Task = System.Threading.Tasks.Task;

namespace TasksManagementApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TagController  : ControllerBase
{
      private readonly ApplicationContext _context;

    public TagController(ApplicationContext context)
    {
        _context = context;
    }
    

    [HttpGet()]
    public IActionResult Get()
    {
       
        return  Ok(_context.Tags.ToList());
    }
    
    [HttpGet("{id:int}")]
    public  IActionResult GetById([FromRoute] int id)
    {
        return Ok(_context.Tags.FirstOrDefault(x => x.Id == id));
    }
    
    [HttpPost]
    public IActionResult Create([FromBody] RequestTagDto data)
    {
        var domainData = new Tag
        {
            Name = data.Name,
            HexadecimalColor = data.HexadecimalColor
        };
        _context.Tags.Add(domainData);
        _context.SaveChanges();
        return Ok(domainData);

    }
    
    [HttpPatch("{id:int}")]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTagDto data)
    {
        var domainData = _context.Tags.FirstOrDefault(x => x.Id == id) ?? throw new Exception();

        domainData.Name = data.Name;
        domainData.HexadecimalColor = data.HexadecimalColor;


        _context.Tags.Update(domainData);
        _context.SaveChanges();
        return Ok(domainData);
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var domainData = _context.Tags.FirstOrDefault(x => x.Id == id) ?? throw new Exception();
        _context.Tags.Remove(domainData);
        _context.SaveChanges();
        return Ok();
    }
}