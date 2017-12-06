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
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return indexArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void Add(T toAdd)
        {
            if (Count > (capacity / 2))
            {
                IncreaseInternalArraySize();
            }
            indexArray[count] = toAdd;
            count++;
        
        }
        private void IncreaseInternalArraySize()
        {
            T[] shiftArray = new T[capacity+capacity];
            
            for (int i = 0; i < Count; i++)
            {
                shiftArray[i] = indexArray[i];
            }
            indexArray = shiftArray;
                        
        }
        public bool Remove(T toRemove)
        {
            for (int i = 0; i < Count; i++)
            {
                if (indexArray[i].Equals(toRemove))
                {
                    count--;
                    ShiftValues(i);
                    return true;
                }
                
            }
            return false;
        }
        private void ShiftValues(int indexNumber)
        {
            for (int i = indexNumber; i < Count; i ++ )
            {
                indexArray[i] = indexArray[i + 1];
            }
        }

        public override string ToString()
        {
            string stringOutcome = "";
            for (int i = 0; i < Count; i ++)
            {
                if (i == Count - 1)
                {
                    stringOutcome += indexArray[i].ToString();
                }
                else
                {
                    stringOutcome += indexArray[i].ToString() + ", ";
                }
            }
            return stringOutcome;
        }

    }
}
