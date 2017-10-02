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
    public abstract class BaseMessageChannel : BaseObservable, IMessageChannel
    {
        protected Dictionary<Type, IComponentSystem> componentSystemMap;

        public void SendMessage(IComponentSystem system, IMessage message)
        {
            this.componentSystemMap[system.GetType()].Update(message);
        }

        public void Subscribe(IComponentSystem system)
        {
            base.Attach(system);
            this.componentSystemMap.Add(system.GetType(), system);
        }

        public void Unsubscribe(IComponentSystem system)
        {
            base.Detach(system);
            this.componentSystemMap.Remove(system.GetType());
        }
    }
}
