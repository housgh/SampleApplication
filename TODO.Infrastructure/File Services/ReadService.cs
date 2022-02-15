using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    internal class ReadService : IReadService
    {
        public string ReadFromFile()
        {
            return "File Content";
        }
    }
}