using System;
namespace 访问者模式
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA() //其他相关操作方法
        {

        }
    }
}
