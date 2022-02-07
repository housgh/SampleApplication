using Common.Domain.Enums;

namespace Common.Domain.Entities
{
    public class ProjectUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public UserRole Role { get; set; }
        
        public User User { get; set; }
        public Project Project { get; set; }
    }
}