namespace EntityComponentSystem.Base
{
    /**
     * Use this class as Base for all of your observers
     */

    public abstract class BaseObserver : IObserver
    {
        protected BaseObserver() {

        }

        public abstract void Update();
    }
}
