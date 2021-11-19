﻿using CleanArchitectureDemo.Domain.Core.Bus;
using CleanArchitectureDemo.Domain.Core.Commands;
using MediatR;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Infrastructure.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
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
