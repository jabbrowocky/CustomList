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

            CustomList<string> firstList = new CustomList<string>() { "dog", "foo", "young" };
            CustomList<string> secondList = new CustomList<string>() { "foo", "dog", "this", "stuff" };

            secondList.RemoveRange(0, 2);
            Console.WriteLine(secondList);
            Console.ReadKey();

        }   
    }
}
