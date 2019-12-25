using System;
namespace 命令模式
{
    //实际的命令
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {

        }
            
        public override void Implement()
        {
            receiver.Action();
        }
    }
}
