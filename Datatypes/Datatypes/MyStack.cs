using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class MyStack
    {
        private Node top = null;

        public object Pop()
        {
            object value = top.Data;
            top = top.Next;
            return value;
        }

        public void Push(object data)
        {
            if (top == null)
            {
                top = new Node { Data = data };
            }
            else
            {
                top = new Node { Data = data, Next = top };
            }
        }

        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }
        }
    }

    
    
}
