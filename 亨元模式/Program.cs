using System;

/*
 * 运用共享技术有效地支持大量细粒度
 *
 * 对象池等
 */


namespace 亨元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f = new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("产品展示",1);
            fx.Use(new User("小菜0"));

            WebSite fy = f.GetWebSiteCategory("产品展示", 2);
            fy.Use(new User("小菜1"));

            WebSite fz = f.GetWebSiteCategory("产品展示", 3);
            fz.Use(new User("小菜2"));

            WebSite f1 = f.GetWebSiteCategory("博客", 4);
            f1.Use(new User("小菜3"));

            WebSite f2 = f.GetWebSiteCategory("博客", 5);
            f2.Use(new User("小菜4"));

            WebSite f3 = f.GetWebSiteCategory("博客", 6);
            f3.Use(new User("小菜5"));

            fx.GetUser();

            Console.WriteLine("网站分类总数为：{0}",f.GetWebSiteCount());

        }
    }
}
