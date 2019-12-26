using System;
/*
 *  使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。将这个对象连成一条链，并沿着这条链传递该请求，知道有一对象处理它为止。
 *
 *
 *  当客户提交一个请求时，请求沿链传递直至又一个ConcreteHandler对象负责处理它。
 */

namespace 职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 4, 14, 22, 18, 3, 27, 20 };

            foreach (var requset in requests)
            {
                h1.HandleRequest(requset);
            }

        }
    }
}
