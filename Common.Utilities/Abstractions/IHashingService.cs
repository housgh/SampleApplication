namespace TODO.Application.Abstractions
{
    public interface IHashingService
    {
        string HashPassword(string password);
    }
}