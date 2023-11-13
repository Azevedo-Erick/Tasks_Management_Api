// using Microsoft.AspNetCore.Mvc;
// using TasksManagementApi.Data;
// using TasksManagementApi.Dtos;
// using TasksManagementApi.Models;
//
// namespace TasksManagementApi.Controllers;
//
// [ApiController]
// [Route("[controller]")]
// public class SubTaskController : ControllerBase
// {
//     private readonly ApplicationContext _context;
//
//     public SubTaskController(ApplicationContext context)
//     {
//         _context = context;
//     }
//     
//     /// <summary>
//     /// Obtém a lista de sub-tarefas.
//     /// </summary>
//     /// <remarks>
//     /// Retorna uma lista de todas as sub-tarefas armazenadas no sistema.
//     /// </remarks>
//     /// <response code="200">A lista de sub-tarefas foi obtida com sucesso.</response>
//     /// <response code="500">Ocorreu um erro interno no servidor.</response>
//     [HttpGet]
//     public IActionResult Get()
//     {
//         return  Ok(_context.SubTasks.ToList());
//     }
//     
//     [HttpGet("{id:int}")]
//     public  IActionResult GetById([FromRoute] int id)
//     {
//         return Ok(_context.SubTasks.FirstOrDefault(x => x.Id == id));
//     }
//     
//     /// <summary>
//     /// Cria um item na To-do list.
//     /// </summary>
//     /// <remarks>
//     /// Exemplo de solicitação:
//     ///
//     ///     POST /api/todo
//     ///     {
//     ///        "id": 1,
//     ///        "name": "Item1",
//     ///        "iscomplete": true
//     ///     }
//     ///
//     /// O JSON enviado no corpo da solicitação deve conter os campos "id," "name," e "iscomplete."
//     /// </remarks>
//     /// <param name="value">O objeto JSON que representa o item a ser criado na To-do list.</param>
//     /// <returns>O novo item criado na To-do list.</returns>
//     /// <response code="201">Retorna o novo item criado.</response>
//     /// <response code="400">Se o item não puder ser criado devido a uma solicitação inválida.</response>
//     [HttpPost("task/{id:int}")]
//     public IActionResult Create([FromBody] RequestSubTaskDto data, [FromRoute] int id)
//     {
//         var task = _context.Tasks.FirstOrDefault(x => x.Id == id);
//         
//         var domainData = new SubTask
//         {
//             Description = data.Description,
//             StartDate = data.StartDate,
//             Name = data.Name,
//             DeadLine = data.DeadLine,
//             Priority = data.Priority,
//             Status = data.Status,
//             Task = task
//         };
//         
//         _context.SubTasks.Add(domainData);
//         _context.SaveChanges();
//         return Ok(domainData);
//
//     }
//     
//     [HttpPatch("{id:int}")]
//     public IActionResult Update([FromRoute] int id, [FromBody] RequestSubTaskDto data)
//     {
//         var domainData = _context.SubTasks.FirstOrDefault(x => x.Id == id) ?? throw new Exception();
//
//         domainData.Description = data.Description;
//         domainData.StartDate = data.StartDate;
//         domainData.Name = data.Name;
//         domainData.DeadLine = data.DeadLine;
//         domainData.Priority = data.Priority;
//         domainData.Status = data.Status;
//
//         _context.SubTasks.Update(domainData);
//         _context.SaveChanges();
//         return Ok(domainData);
//     }
//     
//     [HttpDelete("{id:int}")]
//     public IActionResult Delete([FromRoute] int id)
//     {
//         var domainData = _context.SubTasks.FirstOrDefault(x => x.Id == id) ?? throw new Exception();
//         _context.SubTasks.Remove(domainData);
//         _context.SaveChanges();
//         return Ok();
//     }
// }