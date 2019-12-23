using System;
namespace 模版方法模式
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();

        public abstract void PrimitiveOperation2();

        public void TemplateMetod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
