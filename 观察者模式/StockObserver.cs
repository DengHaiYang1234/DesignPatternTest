using System;
namespace 观察者模式
{
    public class StockObserver
    {
        string name;
        Secreqtary sub;

        public StockObserver(string name,Secreqtary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void Update()
        {
            Console.WriteLine("{0} {1}关闭股票行情，继续工作！",sub.SecretartyAction,name);
        }
    }
}
