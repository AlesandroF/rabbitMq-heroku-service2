using System.Threading.Tasks;
using MassTransit;
using RabbitHeroku;

namespace RabbitHeroku2.Consumer
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        public async Task Consume(ConsumeContext<Ticket> context)
        {
            var data = context.Message;
        }
    }
}