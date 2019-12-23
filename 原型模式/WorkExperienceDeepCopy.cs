using System;
namespace 原型模式
{
    public class WorkExperienceDeepCopy : ICloneable
    {
        string workDate;
        public string WorkDate
        {
            get
            {
                return workDate;
            }
            set
            {
                workDate = value;
            }
        }

        string company;

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
