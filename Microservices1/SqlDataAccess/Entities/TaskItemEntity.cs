﻿namespace SqlDataAccess.Entities
{
    public class TaskItemEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }        
    }
}
