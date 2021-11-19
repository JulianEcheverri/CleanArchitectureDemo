using CleanArchitectureDemo.Domain.Core.Events;
using System;

namespace CleanArchitectureDemo.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeSpan { get; protected set; }

        protected Command()
        {
            TimeSpan = DateTime.Now;
        }
    }
}