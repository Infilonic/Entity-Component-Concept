using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityComponentSystem.Components;

namespace EntityComponentSystem.Base
{
    /// <summary>
    /// An instance of this class manages all Entity objects
    /// </summary>
    class EntityManager
    {
        private static EntityManager instance;
        private Dictionary<uint, Entity> entityList;
        private uint index;

        /// <summary>
        /// Initializes an EntityManager instance
        /// </summary>
        private EntityManager() {
            this.entityList = new Dictionary<uint, Entity>();
            this.index = 0;
            EntityManager.instance = this;
        }

        /// <summary>
        /// Returns the static instance of the EntityManager
        /// </summary>
        /// <returns>EntityManager instance</returns>
        public static EntityManager GetManager()
        {
            if (EntityManager.instance == null)
            {
                new EntityManager();
            }

            return EntityManager.instance;
        }

        /// <summary>
        /// Creates a new Entity and saves its reference
        /// </summary>
        /// <returns>New Entity instance</returns>
        public Entity CreateEntity() {
            var entity = new GeneralEntity(this.index);
            this.entityList.Add(this.index++, entity);
            return entity;
        }

        /// <summary>
        /// Removes a given Entity from its list
        /// </summary>
        /// <param name="id">Entity ID to remove</param>
        public void RemoveEntity(uint id) {
            this.entityList.Remove(id);
        }

        /// <summary>
        /// Returns the Entity by given ID
        /// </summary>
        /// <param name="id">Entity ID</param>
        /// <returns>Specified Entity instance</returns>
        public Entity GetEntityByID(uint id)
        {
            return this.entityList[id];
        }

        /// <summary>
        /// Returns all Entity Objects which contain the specified component
        /// </summary>
        /// <param name="component">Component to search for</param>
        /// <returns>An Entity-Array with all matching Entity objects</returns>
        public Entity[] GetEntitiesByComponent(Component component)
        {
            var entities = new List<Entity>();
            foreach(KeyValuePair<uint, Entity> eP in this.entityList)
            {
                if(eP.Value.HasComponent(component)) {
                    entities.Add(eP.Value);
                }
            }
            return entities.ToArray();
        }
    }
}
