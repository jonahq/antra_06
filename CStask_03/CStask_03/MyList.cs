using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask_03
{
    internal class MyList <T>
    {
        T[] arr = new T[10];
        int size = 10;
        int index = 0;
        public void Add(T elem) 
        {
            index += 1;
            if(index < size)
            {
                arr[index] = elem;
                return;
            }
            else
            {
                size = size * 2;
                Array.Resize(ref arr, size);
                arr[index] = elem;
            }
        }
        public bool Contains(T elem)
        {
            for(int i = 0; i < size; i++)
            {
                if (arr[i].Equals(elem) ) { return true; }
            }
            return false;
        }

        public void Clear()
        {
            index = 0;
            size = 10;
            Array.Clear(arr, 0, size);
        }

        public void insertAt(T element, int idx)
        {
            if(idx <= index)
            {
                if(index + 1 == size)
                {
                    size = size * 2;
                    Array.Resize(ref arr, size);
                }
                for(int i = index + 1; i > index; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[idx] = element;
                index += 1;
            }
        }

        public void deleteAt(int idx)
        {
            if (idx <= index)
            {
                for (int i = idx; i < index; i++)
                {
                    arr[i] = arr[i + 1];
                }
                index -= 1;
            }
        }

        public T Find(int idx) 
        {
            return arr[idx];
        }
    }
}
