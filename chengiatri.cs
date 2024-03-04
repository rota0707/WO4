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
            int[] arrays=new int[array.Length+1];

           if(x<0 || x > array.Length-1)
            {
                Console.WriteLine("không chèn được");
            }
            else
            {
                for (int i = 0; i < x; i++)
                {

                    arrays[i] = array[i];

                }
                arrays[x] = x;
                for (int i = x +1; i < arrays.Length; i++)
                {
                    arrays[i] = array[i - 1];
                }
                Console.WriteLine("Mảng giá tri :");
                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.Write(arrays[i] + " ");
                }

            }

            Console.ReadKey();
          
        }
    }
}
