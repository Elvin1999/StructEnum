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
            string text = Console.ReadLine();


            Accauntant accauntant = new Accauntant();
            accauntant.AskForBonus(text, 150);

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
