using System;
namespace 适配器模式
{
    public class Translate : Player
    {

        LanguageDifficultiesPalyer ldf = new LanguageDifficultiesPalyer();

        public Translate(string name) : base(name)
        {
            ldf.Name = name;
        }

        public override void Attack()
        {
            ldf.AttackBySelfLanguage();
        }

        public override void Defense()
        {
            ldf.DefenceBySelfLanguage();
        }
    }
}
