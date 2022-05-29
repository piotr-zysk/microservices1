using System;

namespace Api1.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
    }
}
