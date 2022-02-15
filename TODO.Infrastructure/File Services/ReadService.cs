using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    public class ReadService : IReadService
    {
        public string ReadFromFile()
        {
            return "File Content";
        }
    }
}