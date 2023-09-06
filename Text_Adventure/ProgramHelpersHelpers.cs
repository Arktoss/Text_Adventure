using System;
using System.Threading.Tasks;

internal static class ProgramHelpersHelpers
{

    static void Main(string[] args, void v, int v)
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
        var v1 = v;

            else if (dice > v; dice <= 8);
        Console.WriteLine();



        Console.ReadKey();
    }
}