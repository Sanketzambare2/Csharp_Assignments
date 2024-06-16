using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Assignment
{

    class CustumQueue {

        public int[] arr = new int[5];
        public int front = 0;
        public int rear = 0;

        public void Enqueue(int el)
        {
            arr[rear] = el;
            rear++;

        }
        public int Dequeue() {

            return arr[front++];
            
        }
        public int peek() {
            return arr[front];
        }
        public void Display() {
            for (int i = front; i < rear; i++) {
                Console.WriteLine(arr[i]);
            }
           
        }
        public bool isEmpty() {
            if (arr.Length==0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            CustumQueue q1 = new CustumQueue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Display();

            Console.WriteLine();
            q1.Dequeue();
            q1.Dequeue();
            q1.Dequeue();
            q1.Display();
            Console.WriteLine(q1.isEmpty());
           
            Console.WriteLine("Top element of queue is :"+q1.peek());
        }
    }
}
