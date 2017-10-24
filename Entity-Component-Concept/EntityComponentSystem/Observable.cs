namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of observables
     */

    public interface Observable
    {
        void Attach(Observer observer);

        void Detach(Observer observer);

        void Notify();
    }
}
