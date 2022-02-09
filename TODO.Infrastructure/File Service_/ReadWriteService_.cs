using System;
using TODO.Application.Abstractions;

namespace TODO.Infrastructure.File_Services
{
    public class ReadWriteService_ : IReadWriteService
    {
        public string ReadFromFile(string filePath)
        {
            return "file Content";
        }

        public void WriteToFile(string content, string filePath)
        {
            Console.WriteLine("Writing To File!");
        }
    }
}