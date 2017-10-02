﻿using System;
using System.Collections.Generic;
using EntityComponentSystem.Components;
using EntityComponentSystem.Exceptions;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your entity derivates
     */

    public abstract class BaseEntity : IEntity
    {
        protected uint id;
        protected Dictionary<Type, IComponent> componentMap; //Needs to be a derivate for custom Exceptions

        protected BaseEntity(uint id) {
            this.id = id;
            this.componentMap = new Dictionary<Type, IComponent>();
        }

        public void AddComponent(IComponent component) {
			try {
				this.componentMap.Add(component.GetType(), component);
			} catch(ComponentConstraintReachedException ccre) {
				//Logger stuff. Print out the component-type and the constraint information.
			}
        }

        public void RemoveComponent(IComponent component) {
            this.componentMap.Remove(component.GetType());
        }

        public bool HasComponent(IComponent component) {
            return (this.componentMap.ContainsKey(component.GetType()));
        }

		public IComponent[] GetComponentsOfType(Type componentType) {
			List<IComponent> cl = new List<IComponent>();
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
