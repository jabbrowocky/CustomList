using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
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
            
        }
        public void Remove()
        {

        }
        
    }
}
