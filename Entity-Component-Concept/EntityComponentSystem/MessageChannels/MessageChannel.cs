using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.Systems;
using EntityComponentSystem.MessageChannels.Messages;

namespace EntityComponentSystem.MessageChannels
{
    /**
     * This inteface is used to assure correct usage of messagechannels
     */

    public interface MessageChannel : Observable
    {
        void Subscribe(ComponentSystem system);
        void Unsubscribe(ComponentSystem system);
        void SendMessage(ComponentSystem system, Message message);
    }
}
