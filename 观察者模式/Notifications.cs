using System;
namespace 观察者模式
{
    //通知者接口
    //把所有对观察者对象的引用保存在一个聚类里。
    public interface Notifications
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState { get; set; }
    }
}
