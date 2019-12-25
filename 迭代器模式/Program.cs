using System;

/*
 * 提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示。
 *
 *
 * 
 */


namespace 迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建聚合类。用于各种对象
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "1";
            a[1] = "2";
            a[2] = "3";
            a[3] = "4";
            a[4] = "5";
            a[5] = "6";
            a[6] = "7";
            a[7] = "8";


            //实例化迭代器类，用于进行迭代
            Iterator i = new ConcreteIterator(a);

            object item = i.First();
            while(!i.IsDone())
            {
                Console.WriteLine(i.CurrentItem());
                i.Next();
            }
        }
    }
}
