using Stack_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Assignment
{

    public class CustomStack
    {

        public int[] arr;
       public int[] newArr;
        public int top;

        public CustomStack() {
            top = 0;
            arr = new int[5];
           
        }
        public void push(int el)
        {
            if (top >= arr.Length)
            {
                newArr = new int[arr.Length + 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
               
                newArr[top] = el;
                arr = newArr;
             
            }
            else
            {
                arr[top] = el;
                
            }
            top++;
        }

        public int pop() {
            return arr[top--];
                
        }
        public int peek() {

            return arr[top-1];
        }

        public bool isEmpty() {
            if (arr.Length == 0)
                return true;
            else
                return false;
        }


        public void display()
        {
            for (int i = 0; i < top; i++) {
                Console.WriteLine(arr[i]);
            }

        }
       
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack s1 = new CustomStack();
            //Console.WriteLine(" After Push, stack is :");
            //s1.push(1);
            //s1.push(2);
            //s1.push(3);

            //s1.display();
            //Console.WriteLine("After pop, stack is ");
            //s1.pop();
            //s1.display();
            //Console.WriteLine();
            //Console.WriteLine("Top element in stack :"+s1.peek());
            //Console.WriteLine();
            //Console.WriteLine("Stack is Empty :"+ s1.isEmpty());

            Console.WriteLine(" After Push 5 element in stack  :");
            s1.push(1);
            s1.push(2);
            s1.push(3);
            s1.push(4);
            s1.push(5);
             s1.display();
            Console.WriteLine("Old array length :"+s1.arr.Length);
            Console.WriteLine("After push 6 element in stack :");
            s1.push(6);
            s1.display();
            Console.WriteLine("New array Length is :" + s1.newArr.Length);
            Console.WriteLine("Top element of new array is :" + s1.peek());
          


        }
    }
}
