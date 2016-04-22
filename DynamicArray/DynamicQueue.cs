using System;


namespace MyDynamicArray
{
    class DynamicQueue<T>
    {
        private DynamicArray<T> Queue;
        public DynamicQueue()
        {
            Queue = new DynamicArray<T>();
        }

        public void Enqueue(T data)
        {
            if (!IsFull())
            {
                Queue.Add(data);
            }
            else
            {
                Console.WriteLine("Queue is Full");
            }
        }

        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T temp = Queue.Get(0);
                Queue.Remove(0);
                return temp;
            }
            else
            {
                Console.WriteLine("Queue is Empty");
                return default(T);
            }

        }

        public bool IsEmpty()
        {
            if (Queue.Size == 0)
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
            if (Queue.Capacity < Queue.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowQueue()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i < Queue.Size; i++)
                {
                    Console.Write("| {0} | ", Queue.Get(i));
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Queue is Empty");
            }
        }
    }
}