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
                else if (i < 0)
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
                else if (i < 0)
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
        public bool Add(T toAdd)
        {
            if (count > (capacity / 2))
            {
                IncreaseInternalArraySize();
            }
            index[count] = toAdd;
            count++;
            return true;        
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
        public bool RemoveAt(int indexNumber)
        {
            if (!(indexNumber >= count))
            {
                ShiftValues(indexNumber);
                count--;
                return true;
            }
            return false;
        }
        private void ShiftValues(int indexNumber)
        {
            for (int i = indexNumber; i < count; i++)
            {
                index[i] = index[i + 1];
            }
        }
             


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    result.Append(index[i]);
                }
                else
                {
                    result.Append(index[i] + " ");
                }
                    
            }
            return result.ToString();
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
        // alternative working + operator overload with foreach loop
        //public static CustomList<T> operator +(CustomList<T>firstList, CustomList<T>secondList)
        //{
        //    CustomList<T> resultList = new CustomList<T>();
        //    foreach(T element in firstList)
        //    {
        //        resultList.Add(element);
        //    }
        //    foreach(T element in secondList)
        //    {
        //        resultList.Add(element);
        //    }
        //    return resultList;
        //}
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> resultList = new CustomList<T>();
            for(int i = 0; i < firstList.Count; i ++)
            {
                resultList.Add(firstList[i]);
            }
            for(int i = 0; i < secondList.Count; i++)
            {
                resultList.Add(secondList[i]);
            }
            return resultList;
        }        
        // alternative working - operator overload method using foreach loop
        //public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        //{
        //    CustomList<T> resultList = new CustomList<T>();
        //    foreach (T element in firstList)
        //    {
        //        if (secondList.Contains(element))
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            resultList.Add(element);
        //        }
        //    }
        //    return resultList;
        //}
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> resultList = new CustomList<T>();
            for(int i = 0; i < firstList.count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    continue;
                }
                else
                {
                    resultList.Add(firstList[i]);
                }                
            }
            return resultList;
        }

        public CustomList<T> Zip(CustomList<T> ZipCombiner)
        {
            CustomList<T> zippedTogether = new CustomList<T>();
            int zipCount;
            zipCount = ZipHelper(ZipCombiner);
            for (int i = 0; i < zipCount; i++)
            {
                zippedTogether.Add(this[i]);
                zippedTogether.Add(ZipCombiner[i]);
            }
            return zippedTogether;
        }
        private int ZipHelper(CustomList<T> ZipCombiner)
        {
            int zipCount;
            if (count > ZipCombiner.Count)
            {
                zipCount = ZipCombiner.Count;
                return zipCount;
            }
            else
            {
                zipCount = count;
                return zipCount;
            }
        }
       
    }
}
