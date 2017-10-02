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
        protected Dictionary<Type, ComponentContainer<IComponent>> componentMap;

        private BaseEntity() {
            this.id = uint.MaxValue;
            this.componentMap = new Dictionary<Type, ComponentContainer<IComponent>>();
        }

        protected BaseEntity(uint id) {
            this.id = id;
            this.componentMap = new Dictionary<Type, ComponentContainer<IComponent>>();
        }

        public virtual void AddComponent(IComponent component, uint allowedComponentCount = 1) {
            ComponentContainer<IComponent> cc;
            if(this.componentMap.ContainsKey(component.GetType())) {
                cc = this.componentMap[component.GetType()];
                if(!cc.AllowedCountReached) {
                    cc.AddComponent(component);
                }
            } else {
                cc = new ComponentContainer<IComponent>(allowedComponentCount);
                cc.AddComponent(component);
                this.componentMap.Add(component.GetType(), cc);
            }
        }

        public void RemoveComponent(IComponent component) {
            this.componentMap[component.GetType()].Clear();
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
