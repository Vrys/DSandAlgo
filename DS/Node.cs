using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Node<T>
    {
        public Node(T data)
        {
            Value = data;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
