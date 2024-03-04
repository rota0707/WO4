using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo2
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
            int[] array= {2,4,5,6,1,8,9};
            Console.WriteLine("Mảng giá tri:");
            for(int i=0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("Nhập vị trí cần chèn giá tri:");

            int x = int.Parse(Console.ReadLine());
            int[] arrays;
      
            for(int i = 0; i < array.Length; i++)
            {
              
                if (x < 1 || x > array.Length)
                {
                    Console.WriteLine("Không chèn đk phần tử trong mảng");
                    break;
                }
                else
                {
                    array[x - 1] = x;
                }


            }
            Console.WriteLine("Mảng giá tri mới:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
          
        }
    }
}
