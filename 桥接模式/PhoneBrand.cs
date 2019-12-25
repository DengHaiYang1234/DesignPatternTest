using System;
namespace 桥接模式
{
    public class PhoneBrand
    {
        protected Software software;

        public void InstallationSoftware(Software software)
        {
            this.software = software;
        }

        public virtual void Run()
        {
            software.Run();
        }
    }
}
