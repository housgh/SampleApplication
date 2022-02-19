using System;
using Common.Domain.Enums;

namespace Common.Domain.Entities
{
    public class UserTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public TaskStatus Status { get; set; }
        public int? CreatedById { get; set; }
        public int? AssignedToId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User AssignedTo { get; set; }
    }
}