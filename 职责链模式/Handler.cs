using System;
namespace 职责链模式
{
    //请求类
    public abstract class Handler
    {
        //继承者
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
