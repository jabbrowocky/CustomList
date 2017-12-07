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
        private T[] index;
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
                return index[i];
            }
            set
            {
                if (i > count)
                {
                    throw new IndexOutOfRangeException();
                }
                index[i] = value;
            }
        }
        //ctor
        public CustomList()
        {
            capacity = 5;
            index = new T[capacity];
        }
        //methods
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return index[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void Add(T toAdd)
        {
            if (count > (capacity / 2))
            {
                IncreaseInternalArraySize();
            }
            index[count] = toAdd;
            count++;
        
        }
        private void IncreaseInternalArraySize()
        {
            T[] capacityIncrease = new T[capacity+capacity];
            
            for (int i = 0; i < count; i++)
            {
                capacityIncrease[i] = index[i];
            }
            index = capacityIncrease;
                        
        }
        public bool Remove(T toRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (index[i].Equals(toRemove))
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
            for (int i = indexNumber; i < count; i ++ )
            {
                index[i] = index[i + 1];
            }
        }

        public override string ToString()
        {
            string outcome = "";
            for (int i = 0; i < count; i ++)
            {
                if (i == Count - 1)
                {
                    outcome += index[i].ToString();
                }
                else
                {
                    outcome += index[i].ToString() + ", ";
                }
            }
            return outcome;
        }
        public bool Contains(T toCheck)
        {
            for (int i = 0; i < count; i ++)
            {
                if (index[i].Equals(toCheck))
                {
                    return true;
                }
                
            }
            return false;
        }
        public static CustomList<T> operator +(CustomList<T>firstList,CustomList<T>secondList)
        {
            CustomList<T> resultList = new CustomList<T>();
            foreach(T element in firstList)
            {
                resultList.Add(element);
            }
            foreach(T element in secondList)
            {
                resultList.Add(element);
            }
            return resultList;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> resultList = new CustomList<T>();
            foreach (T element in firstList)
            {
                if (secondList.Contains(element))
                {
                    firstList.Remove(element);
                }
                else
                {
                    resultList.Add(element);
                }
            }
            return resultList;
        }
    }
}
