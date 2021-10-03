using System;

namespace ExceptionsBank.Entities.Exceptions 
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message){

        }
    }
}