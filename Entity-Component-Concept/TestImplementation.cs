using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.MessageChannels;
using EntityComponentSystem.Systems;

namespace EntityComponentSystem
{
    class TestImplementation
    {
        public static void Main(string[] args)
        {
            var entityManager = EntityManager.GetInstance();
            var entity = entityManager.CreateEntity();

            entity.AddComponent(new HealthComponent(0, 10));
            var cc = new ComponentContainer<HealthComponent>();
        }
    }
}
