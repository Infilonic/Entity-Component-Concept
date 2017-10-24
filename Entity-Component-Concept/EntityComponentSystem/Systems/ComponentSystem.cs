using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.MessageChannels;
using EntityComponentSystem.MessageChannels.Messages;

namespace EntityComponentSystem.Systems
{
    /**
     * This inteface is used to assure correct usage of componentsystems
     */

    public interface ComponentSystem : Observer
    {
        void Update(Message message);
    }
}
