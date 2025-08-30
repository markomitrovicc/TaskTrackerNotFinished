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
    }
}
