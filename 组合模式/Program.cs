using System;
/*
 * 将对象组合成树形结构以表示“部分-整体”的层级结构。组合模式使得用户对单个对象和组合对象的使用具有一致性
 *
 *
 * 若需求中是体现部分与整体层次的结构时，以及希望用户可以忽略组合对象与单个对象的不同，统一地使用组合结构中的所有对象时，就应该考虑用组合模式
 * 举例：比如设置一个登录界面，那么它需要两个按钮加一个输入框，可以组成一个登录界面。取消界面只需要一个按钮就可以组成。
 * 
 */


namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司人财务部"));

            ConcreteCompany comp = new ConcreteCompany("上海华东分公司");
            comp.Add(new HRDepartment("华东公司人力资部"));
            comp.Add(new FinanceDepartment("华东公司财务部"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("南京办事处");
            comp1.Add(new HRDepartment("南京办事处人力资部"));
            comp1.Add(new FinanceDepartment("南京办事处财务部"));
            comp.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("杭州办事处");
            comp2.Add(new HRDepartment("杭州办事处人力资部"));
            comp2.Add(new FinanceDepartment("杭州办事处财务部"));
            comp.Add(comp2);

            Console.WriteLine("\n结构图：");
            root.Display(1);

            Console.WriteLine("\n职责：");
            root.LineOfDuty();


        }
    }
}
