using System;
namespace 中介者模式
{
    //联合国
    public abstract class UnitedNations
    {
        public abstract void SendMessage(string message,Country country);
        public abstract void AddCountry(Country country);
    }
}
