using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T>
    {
        //member variables
        int count;
        int capacity;
        private T[] indexArray;
        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int i]
        {
            get
            {
                if (i > count)
                {
                    throw new IndexOutOfRangeException();
                }
                return indexArray[i];
            }
            set
            {
                if (i > count)
                {
                    throw new IndexOutOfRangeException();
                }
                indexArray[i] = value;
            }
        }
        //ctor
        public CustomList()
        {
            capacity = 5;
            indexArray = new T[capacity];
        }
        //methods
        public void Add(T toAdd)
        {
            if (Count > (capacity / 2))
            {
                AddHelper();
            }
            indexArray[count] = toAdd;
            count++;
        
        }
        private void AddHelper()
        {
            T[] shiftArray = new T[capacity+capacity];
            
            for (int i = 1; i < Count; i++)
            {
                shiftArray[i] = indexArray[i];
            }
            indexArray = shiftArray;
                        
        }
        public void Remove(T toRemove)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
