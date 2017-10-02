using EntityComponentSystem.Components;

namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of entities
     */

    public interface IEntity
    {
        void AddComponent(IComponent component, uint allowedComponentCount = 1);

        void RemoveComponent(IComponent component);

        bool HasComponent(IComponent component);
    }
}
