using System;
/*
 *观察者模式定义了一种一对多的以来关系，让多个观察者对象同时监听某一个主题对象。这个主题对象在状态发生变化时，会通知所有观察者模式，使他们能够自动更新自己。
 */
namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {

            //// ***********常规版，通知者与观察者之间的相互耦合。不可取
            //Secreqtary tongzhizhe = new Secreqtary();
            //StockObserver tongshi1 = new StockObserver("同事1", tongzhizhe);
            //StockObserver tongshi2 = new StockObserver("同事2", tongzhizhe);

            //tongzhizhe.Attach(tongshi1);
            //tongzhizhe.Attach(tongshi2);

            //tongzhizhe.SecretartyAction = "老板来了";
            //tongzhizhe.Notify();


            //// ***********抽象观察者和通知者，但还是存在问题时通知者依然持有观察者，若观察者一旦改变，那么通知者就不会通知任何对象
            //Boss boss = new Boss();

            //Colleague_1 colleague_1 = new Colleague_1("同事1",boss);
            //Colleague_2 colleague_2 = new Colleague_2("同事2", boss);

            //boss.Attach(colleague_1);
            //boss.Attach(colleague_2);

            //boss.Detach(colleague_1);

            //boss.SubjectState = "回来了";

            //boss.Notify();


            // ***********用事件来处理观察者模式

            Boss_Event boss = new Boss_Event();

            Colleague_1_Event colleague_1_Event = new Colleague_1_Event("同事1");

            Colleague_2_Event colleague_2_Event = new Colleague_2_Event("同事2");

            boss.Update += colleague_1_Event.Update1;
            boss.Update += colleague_2_Event.Update2;

            boss.Notify();



        }
    }
}
