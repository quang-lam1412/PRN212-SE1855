﻿using System.Text;

namespace FirstDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phương trình bậc 1");
            Console.WriteLine("Hệ số a");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Hệ số b");
            double b = Double.Parse(Console.ReadLine());
            if (a == 0 && b == 0)
            {
                //0x + 0=0
                Console.WriteLine("Phương trình vô số nghiệm");
            }
            else if(a == 0 && b !=0)
            {
                //0x + 0=0 (với b!=0)==>vô số nghiệm
                Console.WriteLine("Hông có nghiệm nào hết");
            }
            else
            {
                Console.WriteLine("X={0}", -b / a);
            }
            Console.WriteLine();
        }
    }
}
