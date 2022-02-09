namespace TODO.Application.Abstractions
{
    public interface IReadWriteService
    {
        string ReadFromFile(string filePath);
        void WriteToFile(string content, string filePath);
    }
}