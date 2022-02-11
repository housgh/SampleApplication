using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    public class ReadOnlyService : IReadService
    {
        public string ReadFromFile()
        {
            return "File Content";
        }
    }
}