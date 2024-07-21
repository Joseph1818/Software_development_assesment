public class Warrior : Character
{
    public Warrior(string name) : base(name) { }

    public void Slash(Character target)
    {
        target.TakeDamage(15);
        Console.WriteLine($"{target.Name} takes 15 damage, {target.Health} HP remaining");
    }
}

public class Mage : Character
{
    public Mage(string name) : base(name) { }

    public void Fireball(Character target)
    {
        target.TakeDamage(20);
        Console.WriteLine($"{target.Name} takes 20 damage, {target.Health} HP remaining");
    }
}

