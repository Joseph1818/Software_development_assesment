class Program
{
    static void Main(string[] args)
    {
        // Create instances of Warrior and Mage
        Warrior warrior = new Warrior("Warrior");
        Mage mage = new Mage("Mage");

        // Simulate a battle
        warrior.Attack(mage); 
        mage.Fireball(warrior); 
        warrior.Slash(mage); 
        mage.Attack(warrior); 
    }
}
