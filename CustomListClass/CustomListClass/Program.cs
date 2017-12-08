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

            CustomList<string> firstList = new CustomList<string>() { "cheese", "foo", "dog" };
            CustomList<string> secondList = new CustomList<string>() { "foo", "dog", "this", "stuff" };
            secondList.RemoveRange(-1, 3);
            Console.WriteLine(secondList.Count);
            Console.WriteLine(secondList);
            Console.ReadKey();
        }   
    }
}
