using System;

/*
 *将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 
 */

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonThinBuilder thinGuy = new PersonThinBuilder();
            PersonDirector pd = new PersonDirector(thinGuy);
            pd.CreatPerson();
        }
    }
}
