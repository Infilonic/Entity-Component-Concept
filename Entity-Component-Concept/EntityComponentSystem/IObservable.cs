namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of observables
     */

    public interface IObservable
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
