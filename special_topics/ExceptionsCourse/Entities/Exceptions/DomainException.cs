using System;

namespace ExceptionsCourse.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message){

        }
    }
}