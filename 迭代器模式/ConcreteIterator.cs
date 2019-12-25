using System;
namespace 迭代器模式
{
    //具体的迭代器实现类
    public class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
                ret = aggregate[current];

            return ret;
        }
    }
}
