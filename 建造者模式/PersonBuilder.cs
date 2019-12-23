using System;
namespace 建造者模式
{
    public abstract class PersonBuilder
    {
        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
}
