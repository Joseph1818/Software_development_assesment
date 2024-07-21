using System;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Character(string name, int health = 50)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack(Character target)
    {
        target.TakeDamage(10);
        Console.WriteLine($"{target.Name} takes 10 damage, {target.Health} HP remaining");
    }

    public void TakeDamage(int damage)
    {
        Health = Math.Max(0, Health - damage);
    }
}
