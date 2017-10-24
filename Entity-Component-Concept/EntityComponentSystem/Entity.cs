using EntityComponentSystem.Components;
using System;

namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of entities
     */

    public interface Entity
    {
        void AddComponent(Component component);

        void RemoveComponent(Component component);

        bool HasComponent(Component component);

		Component[] GetComponentsOfType(Type componentType);
    }
}
