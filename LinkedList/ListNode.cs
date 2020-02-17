using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicList
{
    public class ListNode<T> //Klass för element T i listan.
    {
        public ListNode(T value)
        {
            this.Value = value;
        }
        
        public T Value { get; set; }

        public ListNode<T> Previous { get; set; }

        public ListNode<T> Next { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
