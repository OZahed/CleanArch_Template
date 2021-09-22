using CleanArch.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTimeOffset TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTimeOffset.UtcNow;
        }
    
    }
}
