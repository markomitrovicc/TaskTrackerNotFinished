using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetTasks()
        {
            // Placeholder for getting tasks logic
            return Ok(new { message = "Get all tasks" });
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            // Placeholder for getting a specific task logic
            return Ok(new { message = $"Get task with ID {id}" });
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] object task)
        {
            // Placeholder for creating a task logic
            return CreatedAtAction(nameof(GetTask), new { id = Guid.NewGuid() }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] object task)
        {
            // Placeholder for updating a task logic
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            // Placeholder for deleting a task logic
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PatchTask(int id, [FromBody] object task)
        {
            // Placeholder for patching a task logic
            return NoContent();
        }
    }
}
