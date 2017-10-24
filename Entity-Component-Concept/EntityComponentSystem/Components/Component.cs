using EntityComponentSystem.Systems;
using EntityComponentSystem.Base;

namespace EntityComponentSystem.Components
{
    /**
     * This inteface is used to assure correct usage of components
     */

    public interface Component : Observable
    {
        void Subscribe(ComponentSystem system);

        void Unsubscribe(ComponentSystem system);

		bool ConstraintReached(Entity constrainedEntity);
    }
}
