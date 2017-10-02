using EntityComponentSystem.Components;
using System;

namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of entities
     */

    public interface IEntity
    {
        void AddComponent(IComponent component);

        void RemoveComponent(IComponent component);

        bool HasComponent(IComponent component);

		IComponent[] GetComponentsOfType(Type componentType);
    }
}
