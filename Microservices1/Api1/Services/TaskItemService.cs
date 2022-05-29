using Api1.Models;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Services
{
    public class TaskItemService : ITaskItemService
    {
        private readonly AppDbContext dbContext;

        public TaskItemService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TaskItem>> GetAll()
        {
            return await dbContext.TaskItems.Select(x => new TaskItem
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                DueDate = x.DueDate
            }).ToListAsync();
        }
    }
}
