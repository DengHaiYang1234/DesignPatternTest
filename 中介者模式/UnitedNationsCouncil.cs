using System;
using System.Collections.Generic;
namespace 中介者模式
{

    public class UnitedNationsCouncil : UnitedNations
    {
        List<Country> countries = new List<Country>();

        public override void AddCountry(Country country)
        {
            countries.Add(country);
        }

        public override void SendMessage(string message, Country country)
        {
            foreach (var _country in countries)
            {
                if(_country == country)
                {
                    country.Notify(message);
                }
            }
        }

        
    }
}
