using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDynamicArray
{
    class DynamicStack<T>: DynamicArray<T>
    {
        private DynamicArray<T> Stack;
        public DynamicStack()
        {
            Stack = new DynamicArray<T>();
        }

        public void Push(T data)
        {
            Stack.Add(data);           
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T temp = Stack.Get(Stack.Size-1);
                Stack.Remove(Stack.Size-1);
                return temp;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }

        }

        public T Peek()
        {
            if (!IsEmpty())
            {                
                return Stack.Get(Stack.Size-1);
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }

        }

        public bool IsEmpty()
        {
            if (Stack.Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (Stack.Capacity < Stack.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowStack()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i < Stack.Size; i++)
                {
                    Console.Write("| {0} | ", Stack.Get(i));
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack is Empty");
            }
        }


    }
}
