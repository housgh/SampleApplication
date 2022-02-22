namespace TODO.Application.Models
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OwnerId { get; set; }
        public string Description { get; set; }
    }
}