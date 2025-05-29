using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Customer
    {
        // cách viết POCO
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public void PrintInfo()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==================================");
            Console.WriteLine($"Customer id={Id}");
            Console.WriteLine($"Customer name={Name}");
            Console.WriteLine($"Customer email={Email}");
            Console.WriteLine($"Customer phone={Phone}");
            Console.WriteLine($"Customer address={Address}");
            Console.WriteLine("==================================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
