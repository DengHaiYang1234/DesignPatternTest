using System;
namespace 命令模式
{

    //命令的抽象类。包含执行者
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Implement();
    }
}
