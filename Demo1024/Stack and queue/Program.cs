using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //stacks 
            //declaration 
            Stack<Student> stackOfStudent = new Stack<Student>();


            //push object onto stack

            stackOfStudent.Push(new Student("Bill"));
            stackOfStudent.Push(new Student("Jill"));
            stackOfStudent.Push(new Student("Jack"));

            //traversal to look at whats on the stack

            foreach(Student s in stackOfStudent)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudent.Count);
            Console.WriteLine();

            //pops to take off things from the stack
            int size = stackOfStudent.Count;
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(stackOfStudent.Pop().Name);
            }
            Console.WriteLine(stackOfStudent.Count);
            Console.WriteLine();

            // queues 
            Queue<Student> studentQueue = new Queue<Student>();

            // put items into the queue 
            studentQueue.Enqueue(new Student("Bill"));
            studentQueue.Enqueue(new Student("Jill"));
            studentQueue.Enqueue(new Student("Jack"));

            // traversal 
            foreach(Student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();

            size = studentQueue.Count;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);

            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();
        }
    }
}
