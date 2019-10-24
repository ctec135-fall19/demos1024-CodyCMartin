using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaration 
            Dictionary<string, Student> studentDictionary = new
                Dictionary<string, Student>();

            //initialize adding to the dictionary. keys on the left, values on the right
            studentDictionary.Add("Bill", new Student("Bill1"));
            studentDictionary["Jill"] = new Student("Jill2");
            studentDictionary["Jack"] = new Student("Jack3");

            //traversal the keys or the values indep
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            foreach (Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }
}
