using Microsoft.AspNetCore.Mvc;
using VueWithAspNetCoreAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace VueWithAspNetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskItemsController : ControllerBase
    {
        private static List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Name = "Tarefa 1", IsComplete = false },
            new TaskItem { Id = 2, Name = "Tarefa 2", IsComplete = true }
        };

        [HttpGet]
        public IEnumerable<TaskItem> Get()
        {
            return tasks;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TaskItem task)
        {
            task.Id = tasks.Count + 1;
            tasks.Add(task);
            return Ok(task);
        }
    }
}