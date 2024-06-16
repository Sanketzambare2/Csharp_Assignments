using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Function___Array
{
    internal class Program
    {
        //Slicing Array
        public static int[] sliceArray(int[] arr, int startIndex, int endIndex) {
            int size = endIndex - startIndex+1;
            int[] newarr = new int[size];

            for (int i = 0; i <size; i++) {
                newarr[i] = arr[startIndex + i];
            }
            return newarr;
        }
        // Insert element in Array
        public static int[] insert(int[] arr, int el, int ind) {
          int[] newArray = new int[arr.Length + 1];
            for (int i = 0; i < ind; i++) {
                newArray[i] = arr[i];
            }
            newArray[ind] = el;
            for (int i = ind; i < arr.Length; i++) {
                newArray[i+1] = arr[i];
            }
            return newArray;
        }
        //Update element in Array
        public static int[] update(int[] arr, int el, int ind)
        {
            int[] newArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) {
                if (i == ind)
                {
                    arr[i] = el;   
                }
                newArray[i] = arr[i];
            }

            return newArray;

        }
        //Reverse array elemet

        public static int[] reverse(int[] arr) {
            int[] narray = new int[arr.Length];

            for (int i = 0;i<arr.Length;i++) {
                narray[i] = arr[arr.Length - 1 - i];
            }

            return narray;
        }



        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("array element is :");
            foreach (int ele in arr) {
                Console.Write(ele+" ");
            }
            Console.WriteLine();
            Console.WriteLine("For slicing array :");
            Console.WriteLine("Enter starting index ");
            int si = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ending index ");
            int ei = int.Parse(Console.ReadLine());


            Console.WriteLine("After Slicing array is :");
            int [] res = sliceArray(arr, si, ei);
            foreach (int el in res) {
                Console.Write(" " + el);
            }
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("For Inserting Element ");
            Console.WriteLine("Enter element for insert");
            int iel = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr an index :");
            int iind = int.Parse(Console.ReadLine());
            int []ires = insert(arr, iel, iind);
            Console.WriteLine("After insert array is :");
            foreach (int el in ires) {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");

            Console.WriteLine(" For Update Array :");
            Console.WriteLine("Enter element for update");
            int el1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index ");
            int ui = int.Parse(Console.ReadLine());
            Console.WriteLine("After update array is :");

            int[] up = update(arr, el1,ui);
            foreach (int el in arr) {
                Console.Write(el + " ");
            }

            Console.WriteLine();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Reverse array is :");
            int[] rev = reverse(arr);
            foreach (int el in rev) {
                Console.Write(el + " ");
            }
          

        }
    }
}
