using TODO.Application.Abstractions;

namespace Common.Utilities.Services
{
    public class HashingService : IHashingService
    {
        public string HashPassword(string password)
        {
            return "Hashed-Password";
        }
    }
}