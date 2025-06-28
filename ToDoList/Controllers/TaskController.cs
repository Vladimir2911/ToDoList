using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTasks(int count)
        {
            List<ToDoTask> tasks = new List<ToDoTask>();

            for (int i = 0; i < count; i++)
            {
                tasks.Add(new ToDoTask() { Name = $"Name+ {i}" });
            }
            return Ok(tasks);
        }
    }
}
