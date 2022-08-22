
Dog first = new Dog() { Name = "Fido", hairColor = "Black", BarkVolume = 8, legCount = 4 };
Dog second = new Dog() { Name = "Nellie", hairColor = "Yellow", BarkVolume = 5, legCount = 4 };
Orangutan third = new Orangutan() { Name = "Fred", hairColor = "Orange", legCount = 2, ThumbLength = 3 };


List<Mammal> pets = new List<Mammal>();
pets.Add(first); //Added fido
pets.Add(second); //Added Nellie
pets.Add(third); //Added Oragutan

foreach (Mammal pet in pets)
{
    string info = pet.ToString(); // CW will call the correct ToString for the object
    Console.WriteLine(info);
}



class Mammal
{
    public string Name;
    public string hairColor; // what color hair 
    public int legCount; //How many legs it walks on 

    public void Walk()
    {
        Console.WriteLine("I am walking");
    }

    // We are overriding what's called a "virtual" functions
    //i.e. A "virtual" function is on that you can override. 

    public override string ToString()
    {
        return "This is a mammal.";
    }
}

class Dog : Mammal
{
    public int BarkVolume; //How loud the dog's bark is


    public override string ToString()
    {
        return $"Dog named {Name}, hair color {hairColor}, {legCount} legs, and barks at a volume of {BarkVolume}";
    }
}


class Orangutan : Mammal
{
    public int ThumbLength; // How long the thumb is 

    public override string ToString()
    {
        return $"Orangutan named {Name}, hair color {hairColor}, {legCount} legs, and has a thumb length of {ThumbLength} inches";
    }
}
