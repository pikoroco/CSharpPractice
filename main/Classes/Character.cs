namespace main.Classes
{
    public abstract class Character
    {
        public int Vitality { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Attack(Character enemy) { }
    }
}