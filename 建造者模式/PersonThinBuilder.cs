using System;
namespace 建造者模式
{
    public class PersonThinBuilder : PersonBuilder
    {
        public override void BuildArmLeft()
        {
            Console.WriteLine("左臂正常");
        }

        public override void BuildArmRight()
        {
            Console.WriteLine("右臂正常");
        }

        public override void BuildBody()
        {
            Console.WriteLine("瘦身体");
        }

        public override void BuildHead()
        {
            Console.WriteLine("小头");
        }

        public override void BuildLegLeft()
        {
            Console.WriteLine("左腿正常");
        }

        public override void BuildLegRight()
        {
            Console.WriteLine("右腿正常");
        }
    }
}
