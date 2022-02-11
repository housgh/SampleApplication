using System;
using Common.Domain.Enums;

namespace TODO.Application.Models
{
    public class UserTaskDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public TaskStatus Status { get; set; }
        public int CreatedById { get; set; }
        public int AssignedToId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}