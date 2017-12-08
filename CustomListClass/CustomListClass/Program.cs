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
            
            //arrange
            CustomList<int> firstHalf = new CustomList<int>() { 1, 2, 3 };
            //act
            firstHalf.RemoveAt(1);
            //Assert
            Console.WriteLine(firstHalf);
            Console.WriteLine(firstHalf.Count);
            Console.ReadKey();
        
        }   
    }
}
