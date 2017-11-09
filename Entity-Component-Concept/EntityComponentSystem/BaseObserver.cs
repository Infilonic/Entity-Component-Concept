namespace EntityComponentSystem.Base
{
    /**
     * Use this class as Base for all of your observers
     */

    /// <summary>
    /// For documentation see <see cref="Observer"/> 
    /// </summary> 
    public abstract class BaseObserver : Observer
    {
        /// <summary>
        /// Initializes an Observer instance
        /// </summary>
        protected BaseObserver() {

        }

        /// <summary>
        /// <para>This method will be called from any Observable
        /// if the state of an Observable changed
        /// </para>
        /// <para>
        /// It is not recommended to call this outside of an Observable object
        /// </para>
        /// </summary>
        public abstract void Update();
    }
}
