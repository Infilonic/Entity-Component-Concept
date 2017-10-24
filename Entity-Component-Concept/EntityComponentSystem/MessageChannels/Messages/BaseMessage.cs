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
    class BaseMessage : Message
    {
        private Entity entity;

        public void SetComponent(Component component)
        {
            throw new NotImplementedException();
        }

        public void SetEntity(Entity entity) {
            throw new NotImplementedException();
        }

        public void SetSystem(ComponentSystem system)
        {
            throw new NotImplementedException();
        }
    }
}
