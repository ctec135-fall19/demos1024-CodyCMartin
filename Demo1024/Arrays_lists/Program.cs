using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            //declaration

            // int[] a1;  // declares an array of ints. No memory associated yet
            int[] a1 = new int[5]; // declares and fixes size

            // initialization and traversal

            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = i * 10 + 1;
            }

            // you can create a new array with the values

            int[] a2 = { 1, 2, 3, 4, 5 };

            // traversal (working through the array by accessing the elements within it)
            foreach(int element in a1)
            {
                Console.WriteLine(element);
                
            }
            Console.WriteLine();


            //lists 
            //declaration. need to call a constructor (the parens)
            List<int> l = new List<int>();

            //initialization (putting things in the list using the index location. 
            l.Add(1);
            l.Add(2);
            l.Add(3);


            // element access 
            l[1] = 22;

            //some other methods 
            l.Insert(2, 99);
            l.Remove(1);
            l.Sort();

            // traversal
            for(int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();

            foreach(int element in l)
            {
                Console.WriteLine(element);
            }




        }
    }
}
