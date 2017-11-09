using System;
using System.Collections.Generic;
using EntityComponentSystem.Components;
using EntityComponentSystem.Exceptions;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your entity derivates
     */

    /// <summary>
    /// For documentation see <see cref="Entity"/> 
    /// </summary>
    public abstract class BaseEntity : Entity
    {
        protected uint id;
        protected Dictionary<Type, Component> componentMap; //Needs to be a derivate for custom Exceptions

        /// <summary>
        /// Initializes an Entity instance
        /// </summary>
        /// <param name="id"></param>
        protected BaseEntity(uint id) {
            this.id = id;
            this.componentMap = new Dictionary<Type, Component>();
        }

        /// <summary>
        /// Adds a component to the Entity
        /// </summary>
        /// <param name="component">Component to add</param>
        public void AddComponent(Component component) {
			try {
				this.componentMap.Add(component.GetType(), component);
			} catch(ComponentConstraintReachedException ccre) {
				//Logger stuff. Print out the component-type and the constraint information.
			}
        }

        /// <summary>
        /// Removes a component from the Entity
        /// </summary>
        /// <param name="component">Component to remove</param>
        public void RemoveComponent(Component component) {
            this.componentMap.Remove(component.GetType());
        }

        /// <summary>
        /// Checks if Entity has the searched component
        /// </summary>
        /// <param name="component">Component to search for</param>
        /// <returns>Returns <c>true</c> if Entity contains the searched Component, otherwise false</returns>
        public bool HasComponent(Component component) {
            return (this.componentMap.ContainsKey(component.GetType()));
        }

        /// <summary>
        /// Returns Component instances of a specified type
        /// </summary>
        /// <param name="componentType">Type of the searched Component</param>
        /// <returns></returns>
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
