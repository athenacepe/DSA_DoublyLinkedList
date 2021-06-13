using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_DLL2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Put the contents of the file into the string array
                string[] lines1 = System.IO.File.ReadAllLines(@"D:\assignment 2\file4.txt");
                string[] lines2 = System.IO.File.ReadAllLines(@"D:\assignment 2\file5.txt");
                string[] lines3 = System.IO.File.ReadAllLines(@"D:\assignment 2\file6.txt");


                //Convert the string array and its contents into an int array
                int[] ints1 = Array.ConvertAll(lines1, int.Parse);
                int[] ints2 = Array.ConvertAll(lines2, int.Parse);
                int[] ints3 = Array.ConvertAll(lines3, int.Parse);


                //Create a 3 doubly linked list 
                DLL a = new DLL();
                DLL b = new DLL();
                DLL c = new DLL();


                //Create for loops to insert the values in the ints array into a corresponding DLL 
                for (int i = 0; i < ints1.Length; i++)
                {
                    DLLNode p = new DLLNode(ints1[i]);
                    a.addNode(p);
                }

                for (int i = 0; i < ints2.Length; i++)
                {
                    DLLNode p = new DLLNode(ints2[i]);
                    b.addNode(p);
                }

                for (int i = 0; i < ints3.Length; i++)
                {
                    DLLNode p = new DLLNode(ints3[i]);
                    c.addNode(p);
                }


                //Output the middle number of each DLL 
                Console.WriteLine("-----Middle numbers in each DLL-----");
                Console.WriteLine("Middle number for DLL A: {0}", a.getMid());
                Console.WriteLine("Middle number for DLL B: {0}", b.getMid());
                Console.WriteLine("Middle number for DLL C: {0}", c.getMid());


                //Output the prime numbers in each DLL
                Console.WriteLine("\n-----Prime numbers in each DLL-----");
                Console.Write("Prime numbers for DLL A: "); a.displayPrime();
                Console.Write("\nPrime numbers for DLL B: "); b.displayPrime();
                Console.Write("\nPrime numbers for DLL C: "); c.displayPrime();

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error.");
            }
        }
    }
}