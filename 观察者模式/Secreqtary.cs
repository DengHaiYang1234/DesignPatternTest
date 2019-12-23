using System;
using System.Collections.Generic;
namespace 观察者模式
{
    public class Secreqtary
    {
        List<StockObserver> observers = new List<StockObserver>();
        string action;

        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (StockObserver o in observers)
            {
                o.Update();
            }
        }


        public string SecretartyAction
        {
            get
            { return action; }
            set { action = value; }
        }
    }
}
