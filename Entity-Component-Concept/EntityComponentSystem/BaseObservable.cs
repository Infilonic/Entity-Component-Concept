using System.Collections.Generic;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your observables
     */

    public abstract class BaseObservable : IObservable
    {
        protected List<IObserver> observerList;

        protected BaseObservable() {
            this.observerList = new List<IObserver>();
        }

        public void Attach(IObserver observer) {
            this.observerList.Add(observer);
        }

        public void Detach(IObserver observer) {
            this.observerList.Remove(observer);
        }

        public void Notify() {
            foreach(IObserver o in this.observerList) {
                o.Update();
            }
        }
    }
}
