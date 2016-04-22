using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //DynamicArray<int> list = new DynamicArray<int>();
            //list.Add(0);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            ////list.Insert(2, 10);
            //Console.WriteLine("--------------------");
            //list.Print();
            //Console.WriteLine("--------------------");            
            //list.Remove(1);            
            //list.Print();
            //Console.WriteLine("--------------------");

            //DynamicQueue<int> myQueue = new DynamicQueue<int>();
            //myQueue.Enqueue(0);
            //myQueue.Enqueue(1);
            //myQueue.Enqueue(2);
            //myQueue.Enqueue(3);
            //myQueue.ShowQueue();
            //myQueue.Dequeue();
            //myQueue.ShowQueue();

            //Console.WriteLine("--------------------");

            DynamicStack<int> myStack = new DynamicStack<int>();
            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.ShowStack();
            int a = myStack.Peek();
            Console.WriteLine(a);
            myStack.Pop();
            myStack.ShowStack();


            Console.ReadKey();
        }
    }
}
