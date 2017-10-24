using System;
using EntityComponentSystem.Base;
using EntityComponentSystem.Systems;

namespace EntityComponentSystem.Components
{
    /**
     * Use this class for all of your components
     */

    public abstract class BaseComponent : BaseObservable, Component
    {
        protected BaseComponent() : base() {

        }

        public void Subscribe(ComponentSystem system) {
            base.Attach(system);
        }

        public void Unsubscribe(ComponentSystem system) {
            base.Detach(system);
        }

		public abstract bool ConstraintReached(Entity constrainedEntity);
    }
}
