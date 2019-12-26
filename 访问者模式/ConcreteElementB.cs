using System;
namespace 访问者模式
{
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }


        public void OperationB() //其他相关操作方法
        {

        }
    }
}
