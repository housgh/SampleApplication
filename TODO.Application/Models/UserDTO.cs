using System;
using Common.Domain.Enums;

namespace TODO.Application.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Mobile { get; set; }
        public UserRole Type { get; set; }
        public DateTime JoinedOn { get; set; }
        public int TasksLimit { get; set; }
    }
}