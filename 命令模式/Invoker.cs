using System;
namespace 命令模式
{
    //命令获取者，通知执行接受者执行
    public class Invoker
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExcuteCommand()
        {
            command.Implement();
        }
    }
}
