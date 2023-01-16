using System;
using main.Classes;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The fight begin!");
            BattleSquare battleSquare = new BattleSquare(
                new Wizard() { Name = "Paul", Age = 25 }, 
                new Gladiator() { Name = "Maximus", Age = 32 }
            );
            battleSquare.Fight();
        }
    }
}