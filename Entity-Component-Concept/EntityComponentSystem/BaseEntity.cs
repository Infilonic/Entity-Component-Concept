using System;
using System.Collections.Generic;
using EntityComponentSystem.Components;
using EntityComponentSystem.Exceptions;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your entity derivates
     */

    public abstract class BaseEntity : Entity
    {
        protected uint id;
        protected Dictionary<Type, Component> componentMap; //Needs to be a derivate for custom Exceptions

        protected BaseEntity(uint id) {
            this.id = id;
            this.componentMap = new Dictionary<Type, Component>();
        }

        public void AddComponent(Component component) {
			try {
				this.componentMap.Add(component.GetType(), component);
			} catch(ComponentConstraintReachedException ccre) {
				//Logger stuff. Print out the component-type and the constraint information.
			}
        }

        public void RemoveComponent(Component component) {
            this.componentMap.Remove(component.GetType());
        }

        public bool HasComponent(Component component) {
            return (this.componentMap.ContainsKey(component.GetType()));
        }

		public Component[] GetComponentsOfType(Type componentType) {
			List<Component> cl = new List<Component>();
			foreach(var component in this.componentMap) {
				if(component.GetType() == componentType) {
					cl.Add(component.Value);
				}
			}
			return cl.ToArray();
		}

        public uint ID {
            get { return this.id; }
        }
    }
}
