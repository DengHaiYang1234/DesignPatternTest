using System;
namespace 工厂方法模式
{
    public abstract class Opeartion
    {
        double numA;
        double numB;

        public double NumA { get { return numA; } set { numA = value; } }
        public double NumB { get { return numB; } set { numB = value; } }

        public abstract double GetResult();
    }
}
