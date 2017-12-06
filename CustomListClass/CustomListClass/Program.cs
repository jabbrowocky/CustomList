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
            CustomList<int> listy = new CustomList<int>() { 1, 2, 3 };
            Console.WriteLine(listy.ToString());
            Console.ReadKey();
        }
    }
}
