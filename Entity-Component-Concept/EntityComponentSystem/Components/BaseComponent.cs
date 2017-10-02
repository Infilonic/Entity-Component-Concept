using System;
using EntityComponentSystem.Base;
using EntityComponentSystem.Systems;

namespace EntityComponentSystem.Components
{
    /**
     * Use this class for all of your components
     */

    public abstract class BaseComponent : BaseObservable, IComponent
    {
        protected BaseComponent() : base() {

        }

        public void Subscribe(IComponentSystem system) {
            base.Attach(system);
        }

        public void Unsubscribe(IComponentSystem system) {
            base.Detach(system);
        }
    }
}
