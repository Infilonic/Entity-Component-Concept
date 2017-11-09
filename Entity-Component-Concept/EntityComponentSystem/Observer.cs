namespace EntityComponentSystem.Base
{
    /**
     * This inteface is used to assure correct usage of observers
     */
     
    /// <summary>
    /// Use this interface for correct implementation of observers
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// <para>This method will be called from any Observable
        /// if the state of an Observable changed
        /// </para>
        /// <para>
        /// It is not recommended to call this outside of an Observable object
        /// </para>
        /// </summary>
        void Update();
    }
}
