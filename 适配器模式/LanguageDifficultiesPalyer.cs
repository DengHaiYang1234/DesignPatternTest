using System;
namespace 适配器模式
{
    //语言不同的球员，需要使用自己的语言
    public class LanguageDifficultiesPalyer
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        public void AttackBySelfLanguage()
        {
            Console.WriteLine("外籍球员的进攻");
        }

        public void DefenceBySelfLanguage()
        {
            Console.WriteLine("外籍球员的防守");
        }
    }
}
