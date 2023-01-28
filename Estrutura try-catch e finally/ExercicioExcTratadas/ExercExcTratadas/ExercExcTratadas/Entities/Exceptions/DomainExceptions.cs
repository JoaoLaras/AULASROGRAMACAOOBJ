using System;


namespace ExercExcTratadas.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }
    }
}
