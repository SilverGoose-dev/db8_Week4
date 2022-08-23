// Main Menu

List<GameCharacter> characters = new List<GameCharacter> ();
characters.Add(new Warrior("Solaire of Astora", 17, 12, "Sunlight Straight Sword"));
characters.Add(new Warrior("Siegward of Catarina", 20, 8, "Zwiehander"));
characters.Add(new Wizard("Big-Hat Logan", 10, 22, 50, 10));
characters.Add(new Wizard("Dusk of Oolacile", 8, 32, 42, 5));
characters.Add(new Wizard("Sorcerer Rogier", 13, 26, 30, 7));

Menu();
Console.ReadLine();

foreach (GameCharacter character in characters)
{
    character.Play();
    Console.WriteLine();
}


Console.ReadLine();



static void Menu()
{
    Console.WriteLine("                 ***WELCOME TO THE DB RPG***");
    Console.WriteLine("     -----------------------------------------------------");
    Console.WriteLine("     |     Press any key to show list of Characters      |");
    Console.WriteLine("     -----------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("         |------------------------------------------------/    ");
    Console.WriteLine("0========|-----O -- O ---------------                    /     ");
    Console.WriteLine("         |----------------------------------------------/      ");
    Console.WriteLine("");

}

// Classes

class GameCharacter
{
    public string name;
    public int strength;
    public int intelligence;
    public GameCharacter(string _name, int _strength, int _intelligence)
    {
        name = _name;
        strength = _strength;
        intelligence = _intelligence;
    }
    
    public virtual void Play()
    {
        Console.WriteLine("You will never see this line!");
    }
}

class Warrior : GameCharacter
{
    public string weaponType;

    public Warrior(string _name, int _strength, int _intelligence, string _weaponType) : base(_name, _strength, _intelligence)
    {
        weaponType = _weaponType;
    }
    public override void Play()
    {
        Console.WriteLine($"Name: {name}\nStrength: {strength}\nIntelligence: {intelligence}\nWeapon Type: {weaponType}");
    }

}


class MagicUsingCharacter : GameCharacter
{
    public int magicEnergy;

    public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicEnergy) : base(_name, _strength, _intelligence)
    {
        magicEnergy = _magicEnergy;
    }

    public override void Play()
    {
        Console.WriteLine("You will never see this line either!");
    }
}


class Wizard : MagicUsingCharacter
{
    public int spellCount;

    public Wizard(string _name, int _strength, int _intelligence, int _magicEnergy, int _spellCount) : base(_name, _strength, _intelligence, _magicEnergy)
    {
        spellCount = _spellCount;
    }
    public override void Play()
    {
        Console.WriteLine($"Name: {name}\nStrength: {strength}\nIntelligence: {intelligence}\nMana: {magicEnergy}\nSpell Count: {spellCount}");
    }

}
