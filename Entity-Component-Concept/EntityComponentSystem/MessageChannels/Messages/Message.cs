using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.MessageChannels;
using EntityComponentSystem.Systems;

namespace EntityComponentSystem.MessageChannels.Messages
{
    public interface Message
    {
        void SetSystem(ComponentSystem system);
        void SetComponent(Component component);

        void SetEntity(Entity entity);
    }
}
