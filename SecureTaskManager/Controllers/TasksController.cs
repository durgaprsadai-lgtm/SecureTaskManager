using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureTaskManager.Services;

namespace SecureTaskManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TasksController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TasksController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetTasks() => Ok(_taskService.GetAll());

        [HttpPost]
        public IActionResult AddTask([FromBody] string description)
        {
            var task = _taskService.Add(description);
            return Ok(task);
        }
    }
}
