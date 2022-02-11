using System;
using Common.Domain.Enums;

namespace Common.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Mobile { get; set; }
        public DateTime JoinedOn { get; set; }
        public UserRole Role { get; set; }
    }
}