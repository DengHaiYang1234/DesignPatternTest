using System;
/*
 * 将一个类的接口转换成客户希望的另外一个接口，适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
 */


namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Translate("姚明");
            player1.Attack();
            player1.Defense();

            Player player2 = new Forward("麦迪");
            player2.Attack();

            Player player3 = new Guard("帕克");
            player3.Defense();
        }
    }
}
