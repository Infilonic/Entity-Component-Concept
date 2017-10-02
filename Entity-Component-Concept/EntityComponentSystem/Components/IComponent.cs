using EntityComponentSystem.Systems;
using EntityComponentSystem.Base;

namespace EntityComponentSystem.Components
{
    /**
     * This inteface is used to assure correct usage of components
     */

    public interface IComponent : IObservable
    {
        void Subscribe(IComponentSystem system);

        void Unsubscribe(IComponentSystem system);
    }
}
