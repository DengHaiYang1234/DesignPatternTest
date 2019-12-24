using System;
namespace 适配器模式
{
    public class Centerforward : Player
    {
        public Centerforward(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("进攻");
        }

        public override void Defense()
        {
            Console.WriteLine("防守");
        }
    }
}
