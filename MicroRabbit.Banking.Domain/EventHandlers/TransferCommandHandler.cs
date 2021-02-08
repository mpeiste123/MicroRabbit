using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Banking.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.EventHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish an event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From,request.To,request.Amount));

            return Task.FromResult(true);
        }
    }
}
