using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    public class ReadOnlyService_ : IReadWriteService
    {
        public string ReadFromFile(string filePath)
        {
            return "File Content";
        }

        public void WriteToFile(string content, string filePath)
        {
            throw new System.NotImplementedException();
        }
    }
}