using System;
/*
 * 定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。模版方法使得子类可以不改变一个算法的结构，即可重定义该算法的某些特定步骤。
 *
 * 用处：例如在求选择题的算法中，只需将题目抽象成一个类，并在每个选择题的答案使用徐方法，那么子类只需实现答案的虚方法即可完成答题。解决重复代码的问题
*/

namespace 模版方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass c;

            c = new ConcreteClassA();
            c.TemplateMetod();

            c = new ConcreteClassB();
            c.TemplateMetod();
        }
    }
}
