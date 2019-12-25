using System;
using System.Collections.Generic;
namespace 组合模式
{
    public class ConcreteCompany : Company
    {
        List<Company> childerns = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            childerns.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (Company company in childerns)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company company in childerns)
            {
                company.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            childerns.Remove(c);
        }
    }
}
