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
    public interface IMessage
    {
        void SetSystem(IComponentSystem system);
        void SetComponent(IComponent component);

        void SetEntity(IEntity entity);
    }
}
