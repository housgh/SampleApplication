using System;

namespace Common.Domain.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string email) :
            base($"Invalid Email Provided. Email Provided: {email}"){}
    }
}