using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTranspose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr=new int[3,3];
            int[,] trnpsarr=new int[3,3];
            int k=1;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Enter element "+(k++)+" : ");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Array you've entered : ");
            Console.WriteLine("----------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j] +"\t");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   trnpsarr[i,j] = Convert.ToInt32(arr[j,i]);
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("TRANSPOSE of the Matrix array : ");
            Console.WriteLine("----------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(trnpsarr[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
