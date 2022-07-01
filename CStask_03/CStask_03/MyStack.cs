using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask_03
{
    internal class MyStack<T> 
    {
        private int size = 0;
        LinkedList<T> stack = new LinkedList<T>();

        public int Count() { return size; }
        public T Pop() { stack.RemoveLast(); size -= 1; return stack.Last.Value; }
        public void Push(T item) { stack.AddLast(item); size += 1; }
    }
}
