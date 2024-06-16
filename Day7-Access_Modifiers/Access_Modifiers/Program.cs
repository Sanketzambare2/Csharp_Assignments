using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{

    public class A
    {
        public int a =10;
        private int b = 20;
        protected int c=30;
        internal int d = 40;
        protected internal int e = 50;
        public void display()
        {
            Console.WriteLine("In internal Class access Public :" + a);
            Console.WriteLine("In intenal Class access Private :"+b);
            Console.WriteLine("In internal Class  access Protected :" + c);
            Console.WriteLine("In intenal Class access Internal :" + d);
            Console.WriteLine("In intenal Class access internal Protected  :" + e);

        }


    }
    class B : A {
        public void display() {
            Console.WriteLine("In child Class access Public :" + a);
            Console.WriteLine("In child Class not access Private :");
            Console.WriteLine("In child Class  access Protected :"+c);
            Console.WriteLine("In child Class access Internal :" + d);
            Console.WriteLine("In child Class access internal Protected  :" +e );

        }
    }
    class C {

        A a1 = new A();
        public void Display() {
           
            Console.WriteLine("In Another Class access Public :"+a1.a);
            Console.WriteLine("In Another Class not access Private :" );
            Console.WriteLine("In Another Class not access Protected :" );
            Console.WriteLine("In Another Class access Internal :" + a1.d);
            Console.WriteLine("In Another Class access internal Protected  :" + a1.e);

        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            A a1 = new A();
            a1.display();
            Console.WriteLine();
            B b1 = new B();
            b1.display();
            Console.WriteLine();
            C c1 = new C();
            c1.Display();
            

        }


    }
}
    
    

