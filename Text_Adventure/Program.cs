using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have to save Our Lord, your the only person able too");
            Task.Delay(20).Wait();
            Console.WriteLine("As you run up to the castle to save The Lord you run into a huge trash monster");
            Task.Delay(20).Wait();
            Console.WriteLine("Before you attack you have to roll a D20 to see the outcome of the interaction");

            Random rnd = new Random();
            int dice = rnd.Next(1, 21);
            string value = $"You rolled a {dice}";
            Console.WriteLine(value);

            if (dice > 7) ;

            
                

            else if (dice > 13);
                

            else
            {
                bool v1 = dice < 14;
                bool v = v1;
            }

            Console.ReadKey();
        }
    }
}

