using System;
using Common.Domain.Enums;
using Common.Domain.Value_Objects;

namespace TODO.Application.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public DateTime JoinedOn { get; set; }
        public int TasksLimit { get; set; }
        public UserRole Role { get; set; }
    }
}