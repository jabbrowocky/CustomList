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
            Console.WriteLine(firstList-secondList);
            Console.ReadKey();
        
        }   
    }
}
