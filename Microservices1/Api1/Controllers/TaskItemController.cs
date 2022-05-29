using Api1.Models;
using Api1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskItemService taskItemService;

        public TaskItemController(ITaskItemService taskItemService)
        {
            this.taskItemService = taskItemService;
        }

        [HttpGet]
        public async Task<ActionResult<TaskItem>> GetAll()
        {
            var taskItems = await taskItemService.GetAll();
            return Ok(taskItems);
        }
    }
}
