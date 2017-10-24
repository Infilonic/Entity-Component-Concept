using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Base;
using EntityComponentSystem.MessageChannels;
using EntityComponentSystem.MessageChannels.Messages;

namespace EntityComponentSystem.Systems
{
    class HealthSystem : BaseComponentSystem
    {
        public override void Update(Message message)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            var em = EntityManager.GetInstance();
            
        }
    }
}
