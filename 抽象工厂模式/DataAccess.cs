using System;
using System.Reflection;
namespace 抽象工厂模式
{
    public class DataAccess
    {
        static readonly string AssemblyName = "抽象工厂模式";
        static readonly string nameSpace = "抽象工厂模式";
        static readonly string className = "SQLUser";

        public static IUser CreatUser()
        {
            string typeName = nameSpace + "." + className;
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(typeName);
        }
    }
}
