using System;
using System.Collections.Generic;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            try
            {
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(5);
                queue.Enqueue(6);
                queue.Enqueue(7);
                queue.Enqueue(8);
                queue.Enqueue(9);
                queue.Enqueue(10);
                queue.Enqueue(11);
            }
            catch (QueueException q)
            {
                Console.WriteLine(q.Message);
            }
            catch (QueueTwoException e)
            {
                Console.WriteLine(e.Message);

            }
                       
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine();
           

        }
    }
}
