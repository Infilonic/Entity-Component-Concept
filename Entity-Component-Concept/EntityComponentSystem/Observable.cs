namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of observables
     */

    /// <summary>
    /// Use this interface for implementation of any Observable
    /// </summary>
    public interface Observable
    {
        /// <summary>
        /// Attach any Observer
        /// to observe any state changes of a Observable instance
        /// </summary>
        /// <param name="observer">Observer instance to attach</param>
        void Attach(Observer observer);

        /// <summary>
        /// Detach a previously attached Observer instance
        /// </summary>
        /// <param name="observer">Observer instance to detach</param>
        void Detach(Observer observer);

        /// <summary>
        /// Notifies every attached Observer instance of a Observable instance
        /// </summary>
        void Notify();
    }
}
