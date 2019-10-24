using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new list node of type string
            //and display its properties

            LinkedListNode<string> lln = new LinkedListNode<string>("orange");
            Console.WriteLine("display properties");
            DisplayProperties(lln);
            Console.WriteLine();

            //create a linked list
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");

            DisplayProperties(lln);
            Console.WriteLine();

            //add
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("after adding other nodes");
            DisplayProperties(lln);
            Console.WriteLine();

            //traversal. created new variable and add the first node to the list

            Console.WriteLine("traversal");
            LinkedListNode<string> node = ll.First;



            //pointed at the first node and runs through using the node.next. Until == null (end of list)
            // you can use previous to run through the back

            while(node != null)
            {
                Console.WriteLine("   {0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();

            
        }




        // showing the properties of each node.
        public static void DisplayProperties(LinkedListNode<String> lln)
        {


            if (lln.List == null)
                Console.WriteLine("   node is not linked");
            else
                Console.WriteLine("   Node belongs to a list with {0} elements", lln.List.Count);

            // telling the node previouse to it to print out its value
            if (lln.Previous == null)
                Console.WriteLine("   previous node is null");
            else
                // lln.previous.value is how to retrieve the value of the node
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);

            if (lln.Next == null)
                Console.WriteLine("   next node is null");
            else
                Console.WriteLine("    Value of next node: {0}", lln.Next.Value);

                    

        }

    }
}
