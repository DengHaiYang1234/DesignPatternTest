using System;
namespace 组合模式
{
    public abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company c);

        public abstract void Remove(Company c);

        public abstract void Display(int depth);

        public abstract void LineOfDuty();//履行职责
    }
}
