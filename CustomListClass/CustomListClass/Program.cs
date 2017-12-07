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
            CustomList<int> evens = new CustomList<int>() { 2, 4, 6};
            CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> result;
            result = odds.Zip(evens);
            Console.WriteLine(result.ToString());
            Console.WriteLine(result.Count);
            Console.ReadKey();
        }
    }
}
