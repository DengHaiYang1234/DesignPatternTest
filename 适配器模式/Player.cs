using System;
namespace 适配器模式
{
    public abstract class Player
    {
        string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
}
