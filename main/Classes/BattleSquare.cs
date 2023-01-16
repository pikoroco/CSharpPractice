using System;
using System.Text;

namespace main.Classes
{
    public class BattleSquare
    {
        public BattleSquare(Character firstFighter, Character secondFighter)
        {
            FirstFighter = firstFighter;
            SecondFighter = secondFighter;
        }
        public Character FirstFighter { get; }
        public Character SecondFighter { get; }
        public void ShowVitalities()
        {
            StringBuilder show = new StringBuilder();
            show.AppendLine("Fighter details:");
            show.AppendLine(FirstFighter.ToString());
            show.AppendLine(SecondFighter.ToString());
            Console.WriteLine(show);
        }
        private bool CheckFightersVitalities()
        {
            if (FirstFighter.Vitality <= 0)
            {
                return false;
            }
            if (SecondFighter.Vitality <= 0)
            {
                return false;
            }
            return true;
        }
        public void Fight()
        {
            do
            {
                Console.WriteLine("First fighter begin the attack");
                FirstFighter.Attack(SecondFighter);
                Console.WriteLine("Second fighter begin the attack");
                SecondFighter.Attack(FirstFighter);
                ShowVitalities();
            } while (CheckFightersVitalities());
        }
    }
}