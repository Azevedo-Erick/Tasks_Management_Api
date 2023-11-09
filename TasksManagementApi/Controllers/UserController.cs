using Microsoft.AspNetCore.Mvc;
using TasksManagementApi.Data;
using TasksManagementApi.Dtos;
using TasksManagementApi.Dtos.Response;
using TasksManagementApi.Models;

namespace TasksManagementApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationContext _context;

    public UserController(ApplicationContext context)
    {
        _context = context;
    }
    
    
    [HttpGet]
    public IActionResult Get()
    {
        return  Ok(_context.Users.ToList().ConvertAll(x=> new ResponseUserDto
        {
            Name = x.Name,
            ProfilePictureFileName = x.ProfilePictureFileName,
            Id = x.Id
        }));
    }
    
    [HttpGet("{id:int}")]
    public  IActionResult GetById([FromRoute] int id)
    {

        return Ok(_context.Users.FirstOrDefault(x => x.Id == id));
    }
    
    [HttpPost]
    public IActionResult Create([FromForm] RequestUserDto data)
    {
        var domainData = new User
        {
            Name = data.Name,
            PasswordHash = data.Password,
            ProfilePictureFileName = data.ProfilePicture.FileName
        };
        _context.Users.Add(domainData);
        _context.SaveChanges();
        return Ok(domainData);

    }
    
    [HttpPatch("{id:int}")]
    public IActionResult Update([FromRoute] int id, [FromForm] RequestUserDto data)
    {
        var domainData = _context.Users.FirstOrDefault(x => x.Id == id) ?? throw new Exception();

        domainData.Name = data.Name;
        domainData.PasswordHash = data.Password;
        domainData.ProfilePictureFileName = data.ProfilePicture.FileName;

        _context.Users.Update(domainData);
        _context.SaveChanges();
        return Ok(domainData);
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var domainData = _context.Users.FirstOrDefault(x => x.Id == id) ?? throw new Exception();
        _context.Users.Remove(domainData);
        _context.SaveChanges();
        return Ok();
    }
}