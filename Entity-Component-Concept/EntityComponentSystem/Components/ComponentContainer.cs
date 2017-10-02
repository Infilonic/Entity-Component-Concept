using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityComponentSystem.Components
{
    public class ComponentContainer<T>
        where T : IComponent
    {
        private uint index;
        private uint allowedComponentCount;
        private Dictionary<uint, T> componentMap;

        public ComponentContainer(uint allowedComponentCount = 1)
        {
            this.index = 0;
            this.allowedComponentCount = allowedComponentCount;
        }

        public void AddComponent(T component)
        {
            if(component.GetType() == typeof(T))
            {
                this.componentMap.Add(this.index++, component);
            }
        }

        public void RemoveComponentByID(uint id) {
            this.componentMap.Remove(id);
        }

        public void Clear() {
            this.componentMap.Clear();
        }

        public IComponent GetComponentByID(uint id)
        {
            return this.componentMap[id];
        }

        public IComponent[] GetAllComponents()
        {
            var components = new IComponent[this.allowedComponentCount];
            for(uint i = 0; i < this.componentMap.Count; i++) {
                components[i] = this.GetComponentByID(i);
            }
            /*foreach (KeyValuePair<uint, T> cP in this.components)
            {
                components[i++] = cP.Value;
            }
            */
            return components;
        }

        public bool AllowedCountReached {
            get {
                return (this.componentMap.Count == this.allowedComponentCount);
            }
        }

        public bool IsEmpty {
            get {
                return (this.componentMap.Count == 0);
            }
        }
    }
}
