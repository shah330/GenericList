using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedant_Shoppping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int entered = 0;
            VedantList List = new VedantList();

            while (end == false)
            {
                Console.WriteLine("Press 1 to Add, 2 to remove, 3 to view your list, and 4 to end the program");
                entered = int.Parse(Console.ReadLine());
                if (entered == 1)
                {
                    Console.WriteLine("What do you want to add?");
                    List.Add(Console.ReadLine());
                }
                else if (entered == 2)
                {
                    Console.WriteLine("What do you want to remove");
                    List.Remove(Console.ReadLine());
                }
                else if (entered == 3)
                {
                    List.Print();
                }
                else if(entered == 4)
                {
                    end = true;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            }

            Console.ReadLine();
        }
    }
}
