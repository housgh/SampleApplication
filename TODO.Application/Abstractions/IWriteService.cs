namespace TODO.Application.Abstractions
{
    public interface IWriteService
    {
        void WriteToFile(string content, string filePath);
    }
}