using System;

namespace TODO.Application.Exceptions
{
    public class TaskLimitExceededException : Exception
    {
        public TaskLimitExceededException(string message) : base(message){}
    }
}