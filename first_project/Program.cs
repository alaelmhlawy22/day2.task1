using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($" {num} * {i} = {num * i}");
            }
        }
    }
}
