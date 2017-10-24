using System.Collections.Generic;

namespace EntityComponentSystem.Base
{
    /**
     * Use this class for all of your observables
     */

    public abstract class BaseObservable : Observable
    {
        protected List<Observer> observerList;

        protected BaseObservable() {
            this.observerList = new List<Observer>();
        }

        public void Attach(Observer observer) {
            this.observerList.Add(observer);
        }

        public void Detach(Observer observer) {
            this.observerList.Remove(observer);
        }

        public void Notify() {
            foreach(Observer o in this.observerList) {
                o.Update();
            }
        }
    }
}
