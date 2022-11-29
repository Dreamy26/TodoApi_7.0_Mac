using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; } // representing DTO approach Data Transfer Object, adding secret field
    }

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

