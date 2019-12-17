using System;
namespace 工厂模式
{
    public abstract class Opeartion
    {
        protected double numA;
        protected double numB;

        public double NumA { get { return numA; } set { numA = value; } }

        public double NumB { get { return numB; } set { numB = value; } }

        public abstract double GetResult();
    }
}
