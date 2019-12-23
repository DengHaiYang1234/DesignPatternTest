using System;
using System.Collections.Generic;
namespace 观察者模式
{
    public class Boss : Notifications
    {
        List<Observer> observers = new List<Observer>();

        string action;

        public string SubjectState { get { return action; } set { action = value; } }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
                observer.Update();
        }
    }
}
