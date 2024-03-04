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
           
            int[] array;
            Console.WriteLine("Nhập trí trị cho mảng có 5 phần tử:");
            array = new int[5];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Phần tử " + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Mảng giá trị: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }
            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Giá trị lớn nhất trong mảng trên là :" + max + " , ở vị trí " + index);
            Console.ReadKey();

        }
    }
}
