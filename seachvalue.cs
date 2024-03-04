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
            // du lieu
            string[] data = { "nam", "huong", "hung", "chien", "ngoc", "linh" };
            Console.WriteLine("Nhập tên tìm kiếm :");
            string name = Console.ReadLine();
            if (data != null)
            {
                bool check = false;
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Equals(name))
                    {
                        Console.WriteLine("Position of the students in the list " + name + " is: " + (i + 1));
                        check = true;
                        break;
                    }

                }
                if (check == false)
                {
                    Console.WriteLine("Not found" + name + " in the list.");
                }
            }
            else
            {
                Console.WriteLine("Data rỗng");
            }
            Console.ReadKey();
        }
    }
}
