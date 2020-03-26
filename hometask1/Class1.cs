using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    public class QueueException : Exception
    {
        public override string Message
        {
            get { return "Queue full"; }
        }
    }
    public class QueueTwoException : Exception
    {
        public override string Message { get => "Queue empty"; }
    }
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;


        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
            {
                head = tail;
            }
            else
            {
                tempNode.Next = tail;
            }
            count++;
            if (count <= 10)
                throw new QueueException();
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new QueueTwoException();
           
            T g = head.Data;
            head = head.Next;
            count--;
            return g;
            
           
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }
}