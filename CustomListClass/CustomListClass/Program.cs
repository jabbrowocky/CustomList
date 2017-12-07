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
            CustomList<int> test1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> toZip = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result;
            result = test1.Zip(toZip);
            Console.WriteLine(result.ToString());
            Console.WriteLine(result.Count);
            result.Remove(1);
            Console.WriteLine(result.ToString());
            Console.WriteLine(result.Count);
            Console.ReadKey();
        }
    }
}
