using System;

namespace main.Classes
{
    public class Gladiator : Character
    {
        public Gladiator() => Vitality = 140;
        public override void Attack(Character enemy) => enemy.Vitality -= new Random().Next(2,6);
        public override string ToString() => $"Vitality: {Vitality}, Name: {Name}";
    }
}