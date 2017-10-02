using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.Systems;

namespace EntityComponentSystem.MessageChannels.Messages
{
    class BaseMessage : IMessage
    {
        private IEntity entity;

        public void SetComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void SetEntity(IEntity entity) {
            throw new NotImplementedException();
        }

        public void SetSystem(IComponentSystem system)
        {
            throw new NotImplementedException();
        }
    }
}
