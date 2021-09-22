using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    // this is going to be  our messaging Bus
    public sealed class InMemoryBus: IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;   
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
