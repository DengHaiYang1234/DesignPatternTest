using System;
using System.Collections.Generic;
namespace 亨元模式
{
    public class WebSiteFactory
    {
        Dictionary<string, WebSite> flyWights = new Dictionary<string, WebSite>();

        public WebSite GetWebSiteCategory(string key,int num)
        {
            if (!flyWights.ContainsKey(key))
            {
                flyWights.Add(key, new ConcreteWebSite(key, num));
            }

            return flyWights[key];
        }

        public int GetWebSiteCount()
        {
            return flyWights.Count;
        }
    }
}
