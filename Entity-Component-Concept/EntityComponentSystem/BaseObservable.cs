using System.Collections.Generic;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your observables
     */

    /// <summary>
    /// For documentation see <see cref="Observable"/> 
    /// </summary>
    public abstract class BaseObservable : Observable
    {
        protected List<Observer> observerList;

        /// <summary>
        /// Initializes an Observable instance
        /// </summary>
        protected BaseObservable() {
            this.observerList = new List<Observer>();
        }

        /// <summary>
        /// Attach any Observer
        /// to observe any state changes of a Observable instance
        /// </summary>
        /// <param name="observer">Observer instance to attach</param>
        public void Attach(Observer observer) {
            this.observerList.Add(observer);
        }

        /// <summary>
        /// Detach a previously attached Observer instance
        /// </summary>
        /// <param name="observer">Observer instance to detach</param>
        public void Detach(Observer observer) {
            this.observerList.Remove(observer);
        }

        /// <summary>
        /// Notifies every attached Observer instance of a Observable instance
        /// </summary>
        public void Notify() {
            foreach(Observer o in this.observerList) {
                o.Update();
            }
        }
    }
}
