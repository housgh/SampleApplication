using System;
using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    public class ReadWriteService : IReadService, IWriteService
    {
        public string ReadFromFile()
        {
            return "File Content";
        }

        public void WriteToFile(string content, string filePath)
        {
            Console.WriteLine("Writing To File!");
        }
    }
}