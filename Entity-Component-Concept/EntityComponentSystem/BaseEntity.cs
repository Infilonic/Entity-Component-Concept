using System;
using System.Collections.Generic;
using EntityComponentSystem.Components;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your entity derivates
     */

    public abstract class BaseEntity : IEntity
    {
        protected uint id;
        protected Dictionary<Type, IComponent> componentMap;

        protected BaseEntity(uint id) {
            this.id = id;
            this.componentMap = new Dictionary<Type, IComponent>();
        }

        public void AddComponent(IComponent component) {
            if(!component.ConstraintReached(this)) {
				this.componentMap.Add(component.GetType(), component);
			}
        }

        public void RemoveComponent(IComponent component) {
            this.componentMap.Remove(component.GetType());
        }

        public bool HasComponent(IComponent component) {
            return (this.componentMap.ContainsKey(component.GetType()));
        }

        public uint ID {
            get { return this.id; }
        }
    }
}
