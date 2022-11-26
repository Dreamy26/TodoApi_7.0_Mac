using System;
namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } // Unique key for a relational database
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

