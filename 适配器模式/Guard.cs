using System;
namespace 适配器模式
{
    public class Guard : Player
    {
        public Guard(string name) : base(name)
        {
        }

        public override void Attack()
        {
            
        }

        public override void Defense()
        {
            Console.WriteLine("防守");
        }
    }
}
