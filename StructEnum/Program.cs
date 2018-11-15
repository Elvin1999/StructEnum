using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    enum WorkerPosition
    {
        Manager = 160, Developer = 170, Intern = 80
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager = 160, Developer = 170, Intern = 80");
            Console.WriteLine("Worker Position");
            string text = Console.ReadLine();
            Console.WriteLine("Work hours per month");
            int hours = Convert.ToInt32(Console.ReadLine());
            Accauntant accauntant = new Accauntant();
            if (accauntant.AskForBonus(text, hours))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You can get *Bonus*");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can not get *Bonus*");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }
    }
    struct Accauntant
    {

        public bool AskForBonus(string worker, int hours)
        {

            var a = worker.Trim();
            var b = a.ToLower();
            if (b == "developer" && hours >= (int)WorkerPosition.Developer)
            {
                return true;
            }
            else if (b == "manager" && hours >= (int)WorkerPosition.Manager)
            {
                return true;
            }
            else if (b == "intern" && hours >= (int)WorkerPosition.Intern)
            {
                return true;
            }
            return false;
        }
    }
}
