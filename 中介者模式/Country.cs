using System;
namespace 中介者模式
{
    public abstract class Country
    {
        protected UnitedNations  unitedNations;

        public Country(UnitedNations unitedNations)
        {
            this.unitedNations = unitedNations;
            unitedNations.AddCountry(this);
        }

        public abstract void SendMessage(string message, Country country);
        public abstract void Notify(string message);
    }
}
