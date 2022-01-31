using System;

namespace Entities.Execeptions
{
    class DomainExcepetion : ApplicationException
    {
        public DomainExcepetion(string message)
               : base(message) { }
    }
}