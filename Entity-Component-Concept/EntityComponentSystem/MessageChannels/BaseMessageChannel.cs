using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Base;
using EntityComponentSystem.Systems;
using EntityComponentSystem.MessageChannels.Messages;

namespace EntityComponentSystem.MessageChannels
{
    public abstract class BaseMessageChannel : BaseObservable, MessageChannel
    {
        protected Dictionary<Type, ComponentSystem> componentSystemMap;

        public void SendMessage(ComponentSystem system, Message message)
        {
            this.componentSystemMap[system.GetType()].Update(message);
        }

        public void Subscribe(ComponentSystem system)
        {
            base.Attach(system);
            this.componentSystemMap.Add(system.GetType(), system);
        }

        public void Unsubscribe(ComponentSystem system)
        {
            base.Detach(system);
            this.componentSystemMap.Remove(system.GetType());
        }
    }
}
