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
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4 };
            Console.WriteLine(list1);
            Console.ReadKey();
            List<int> list2 = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine(list2);
            Console.ReadKey();
        }
    }
}
