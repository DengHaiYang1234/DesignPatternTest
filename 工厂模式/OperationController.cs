using System;
namespace 工厂模式
{
    public class OperationController
    {
        public static Opeartion CreatOperation(string o)
        {
            Opeartion oper = null;
            switch (o)
            {
                case "+":
                    oper = new Addition();
                    break;
                case "-":
                    oper = new Subtraction();
                    break;
                case "*":
                    oper = new Mul();
                    break;
                case "/":
                    oper = new Dev();
                    break;
            }
            return oper;
        }
    }
}
