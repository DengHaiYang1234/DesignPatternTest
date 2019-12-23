using System;
namespace 建造者模式
{
    public class PersonDirector
    {
        PersonBuilder builder;
        public PersonDirector(PersonBuilder builder)
        {
            this.builder = builder;
        }

        public void CreatPerson()
        {
            builder.BuildArmLeft();
            builder.BuildArmRight();
            builder.BuildBody();
            builder.BuildHead();
            builder.BuildLegLeft();
            builder.BuildLegRight();
        }
    }
}
