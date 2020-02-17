using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDataStrucures
{
    public interface IQueue<T> 
    {
        void Enqueue(T value);

        T Peek();

        T Dequeue();

        void Clear();
    }
}
