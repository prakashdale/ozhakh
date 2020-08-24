using System.Threading.Tasks;
using Convey.CQRS.Events;

namespace ozhakh.application.Services
{
    public interface IMessageBroker
    {
        Task PublishAsync(params IEvent[] events);
    }
}