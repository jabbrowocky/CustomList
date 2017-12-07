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
            CustomList<bool> listy = new CustomList<bool>() { true, false, false };
            Console.WriteLine(listy.ToString());
            Console.WriteLine(listy.Count);
            listy.Remove(false);
            Console.WriteLine(listy.ToString());
            Console.WriteLine(listy.Count);
            listy.Remove(true);
            Console.WriteLine(listy.ToString());
            Console.WriteLine(listy.Count);
            Console.WriteLine(listy.Contains(true));
                Console.ReadKey();
        }
    }
}
