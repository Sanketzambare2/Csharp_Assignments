using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => method1());
            Task t2 = Task.Run(() => method2());
            Task t3 = Task.Run(() => method3());

           
            

            Console.WriteLine("All methods completed execution.");
        }

        static void method1()
        {
            string filePath = "D:\\Wipro\\Data\\log1.txt";
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 1; i <= 100; i++)
            {
                
                sw.WriteLine("Number : " + i);
                Task.Delay(200).Wait(); 
            }
            sw.Close();
        }

        static void method2()
        {
            string filePath = "D:\\Wipro\\Data\\log2.txt";
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 1; i <= 100; i++)
            {
               
                sw.WriteLine("Number : " + i);
                Task.Delay(200).Wait();
            }
            sw.Close();
        }

        static void method3()
        {
            string filePath = "D:\\Wipro\\Data\\log3.txt";
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 1; i <= 100; i++)
            {
                
                sw.WriteLine("Number : " + i);
                Task.Delay(200).Wait(); 
            }
            sw.Close();
        }
    }
}
