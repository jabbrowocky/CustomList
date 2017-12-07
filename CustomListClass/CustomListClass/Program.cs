using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 2, 7 };
            CustomList<int> result;
            result = list1 - list2;
            Console.Write(result.ToString());
            Console.ReadKey();
        }
    }
}
