using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.Systems;
using EntityComponentSystem.MessageChannels.Messages;

namespace EntityComponentSystem.MessageChannels
{
    /**
     * This inteface is used to assure correct usage of messagechannels
     */

    public interface IMessageChannel : IObservable
    {
        void Subscribe(IComponentSystem system);
        void Unsubscribe(IComponentSystem system);
        void SendMessage(IComponentSystem system, IMessage message);
    }
}
