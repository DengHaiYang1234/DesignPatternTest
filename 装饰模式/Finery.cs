using System;
namespace 装饰模式
{
    public class Finery : Person
    {
        protected Person component;

        public Finery()
        {

        }

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
                component.Show();
        }

    }
}
