using System;
namespace 亨元模式
{
    public abstract class WebSite
    {
        protected int testNum = 0;
        protected User currentUser;
        public abstract void Use(User user);
        public abstract void GetUser();
    }
}
