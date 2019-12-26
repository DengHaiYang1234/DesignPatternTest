using System;
namespace 访问者模式
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
