//Always start bu building your classes. "Model First"
//    Make an instance of each as you go to test it out
// Then make lists or whatever for your app.
// Populate the list with inital data

// Break the app up into individual tasks, which we put into their own methods.
// In thie case:
//             Initialize -- populates the list with initial data. 
//             PrintMenu -- prints out a menu and asks for user's choice
//             Buy -- buys whatever the user chose. I>E removes from list
//             AddNew -- Adds another instance of the class to the list


//Data operations:
//      Added to it  (Create)
//      Printed it all out  (read)
//      Edit (we skipped this part)
//      Removed from it  (Delete)
//      **CRUD**
// Get the app working for one time around 
// And finally add the "Would you like to go again" things


List<Media> allmedia = new List<Media>();
Init(allmedia);

while (true)
{
    Console.Clear();
    string choice = PrintMenu(allmedia).ToLower();
    if (choice == "a")
    {
        AddNew(allmedia);
    }
    else if (choice == "q")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        int index = int.Parse(choice) - 1;
        Buy(allmedia, index);
    }
}

static void Init(List<Media> thelist)
{
    Video video1 = new Video("The Shining", "Stanley Kubrik", "Horror", "R");
    thelist.Add(video1);

    Digital dig1 = new Digital("The Wall", "Rock", "Pink Floyd", 80, "iTunes");
    thelist.Add(dig1);

    Vinyl vin1 = new Vinyl("The White Album", "Rock", "The Beatles", 45, 1000);
    thelist.Add(vin1);

    dig1 = new Digital("Invisible Touch", "Rock", "Genesis", 50, "iTunes");
    thelist.Add(dig1);
}

static void Buy(List<Media> thelist, int index)
{
    Console.WriteLine($"Is this the item you want to buy?");
    Console.WriteLine(thelist[index]);
    Console.Write("Y/N: ");
    string yesno = Console.ReadLine().ToLower();
    if (yesno == "y" || yesno == "yes")
    {
        thelist.RemoveAt(index);
        Console.WriteLine("Item Purchased!");
    }
    else
    {
        Console.WriteLine("Thanks anyway!");
    }
}

static void AddNew(List<Media> thelist)
{
    Console.Write("What would you like to add (video/digital/vinyl):  ");
    string type = Console.ReadLine().ToLower();
    Console.Write("Title: ");
    string title = Console.ReadLine();
    Console.Write("Genre: ");
    string genre = Console.ReadLine();
    if (type == "video")
    {
        Console.Write("Director: ");
        string director = Console.ReadLine();

        Console.Write("Rating: ");
        string rating = Console.ReadLine();

        thelist.Add(new Video(title, genre, director, rating));
    }
    else if (type == "digital")
    {
        Console.Write("Artist: ");
        string Artist = Console.ReadLine();
        
        Console.Write("Duration: ");
        string duration = Console.ReadLine();

        Console.Write("Platform: ");
        string platform = Console.ReadLine();

        thelist.Add(new Digital(title, genre, Artist, int.Parse(duration), platform));
    }
    else if (type == "vinyl")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine();

        Console.Write("Duration: ");
        string duration = Console.ReadLine();

        Console.Write("count: ");
        string count = Console.ReadLine();

        thelist.Add(new Vinyl(title, genre, artist, int.Parse(duration), int.Parse(count)));
    }
    Console.WriteLine();
}

static string PrintMenu(List<Media> thelist)
{
    Console.WriteLine("Choose a media other option: ");
    for (int index = 0; index < thelist.Count; index++)
    {
        Media med = thelist[index];
        Console.WriteLine($"{index + 1}: {med}");
    }
    Console.WriteLine("\n(A)dd new media.");
    Console.WriteLine("(Q)uit.");
    Console.Write("Your choice:  ");
    string entry = Console.ReadLine();
    return entry;
}

class Media
{
    public string Title;
    public string Genre;

    public Media(string _Title, string _Genre)
    {
        Title = _Title;
        Genre = _Genre;
    }

    public virtual void Play()
    {
        Console.WriteLine("The media is playing.");
    }

}

class Video : Media
{
    public string Director;
    public string Rating;

    public Video(string _Title, string _Genre, string _Director, string _Rating)
        : base(_Title, _Genre)
    {
        Director = _Director;
        Rating = _Rating;
    }
    
    public override void Play()
    {
        Console.WriteLine(ToString);
    }

    public override string ToString()
    {
        return $"Video {Title} ({Genre}) Directed by {Director} Rated {Rating}";
    }
}

class Music : Media
{
    public string Artist;
    public int Duration;

    public Music(string _Title, string _Genre, string _Artist, int _Duration)
        : base(_Title, _Genre)
    {
        Artist = _Artist;
        Duration = _Duration;
    }
        

        public override void Play()
    {
        Console.WriteLine("Music");
    }
}

class Digital : Music
{
    public string Platform;
    public Digital(string _Title, string _Genre, string _Artist, int _Duration, string _Platform)
        :base(_Title, _Genre, _Artist, _Duration)
    {
        Platform = _Platform; 
    }

    public override void Play()
    {
        Console.WriteLine(ToString);
    }

    public override string ToString()
    {
        return $"Digital {Title} ({Genre}) by {Artist}, {Duration} minutes on {Platform}";
    }

}

class Vinyl : Music
{
    public int Count;

    public Vinyl(string _Title, string _Genre, string _Artist, int _Duration, int _Count)
        :base(_Title, _Genre, _Artist, _Duration)
    {
        Count = _Count;
    }

    public override void Play()
    {
        Console.WriteLine(ToString);
    }

    public override string ToString()
    {
        return $"Vinyl {Title} ({Genre}) by {Artist}, {Duration} minutes. {Count} limited copies.";
    }
}