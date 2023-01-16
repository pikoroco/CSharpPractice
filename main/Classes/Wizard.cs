using System;

namespace main.Classes
{
    public class Wizard : Character
    {
        public Wizard() => Vitality = 120;
        public override void Attack(Character enemy) => enemy.Vitality -= new Random().Next(1,10);
        public override string ToString() => $"Vitality: {Vitality}, Name: {Name}";
    }
}