using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Components;

namespace EntityComponentSystem.Base
{
    class EntityManager
    {
        private static EntityManager instance;
        private Dictionary<uint, IEntity> entityList;
        private uint index;

        private EntityManager() {
            this.entityList = new Dictionary<uint, IEntity>();
            this.index = 0;
        }

        public static EntityManager GetInstance()
        {
            if (EntityManager.instance == null)
            {
                return new EntityManager();
            }

            return EntityManager.instance;
        }

        public IEntity CreateEntity() {
            var entity = new GeneralEntity(this.index);
            this.entityList.Add(this.index++, entity);
            return entity;
        }

        public void RemoveEntity(uint id) {
            this.entityList.Remove(id);
        }

        public IEntity GetEntityByID(uint id)
        {
            return this.entityList[id];
        }

        public IEntity[] GetEntitiesByComponent(IComponent component)
        {
            var entities = new List<IEntity>();
            foreach(KeyValuePair<uint, IEntity> eP in this.entityList)
            {
                if(eP.Value.HasComponent(component)) {
                    entities.Add(eP.Value);
                }
            }
            return entities.ToArray();
        }
    }
}
