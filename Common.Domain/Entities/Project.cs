namespace Common.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string Description { get; set; }

        public User Owner { get; set; }
    }
}