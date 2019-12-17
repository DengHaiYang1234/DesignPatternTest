using System;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Opeartion oper = OperationController.CreatOperation("+");
            oper.NumA = 10;
            oper.NumB = 20;

            

            Console.WriteLine(oper.GetResult());
        }
    }
}
