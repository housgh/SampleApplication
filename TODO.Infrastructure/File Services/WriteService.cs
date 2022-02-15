using System;
using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    public class WriteService : IWriteService
    {

        public void WriteToFile(string content, string filePath)
        {
            Console.WriteLine("Writing To File!");
        }
    }
}