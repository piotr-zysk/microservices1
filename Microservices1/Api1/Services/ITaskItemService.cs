using Api1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api1.Services
{
    public interface ITaskItemService
    {
        Task<List<TaskItem>> GetAll();
    }
}
