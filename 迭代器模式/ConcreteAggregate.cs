using System;
using System.Collections.Generic;
namespace 迭代器模式
{
    //具体的聚合类
    public class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();

        public override Iterator CreatIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            { return items.Count; }
        }

        public object this[int index]
        {
            get
            {
                return items[index];
            }

            set
            {
                items.Insert(index,value);
            }
        }
    }
}
