List<Rectangle> rects = new List<Rectangle>();


Rectangle rect1 = new Rectangle("Fred", 3.5, 4.2);
//Console.WriteLine(rect1);
rects.Add(rect1);

Rectangle rect2 = new Rectangle("Sally", 4.6, 5.5);
//Console.WriteLine(rect2);
rects.Add(rect2);

Console.WriteLine("Which Rectangle?  ");
string entry = Console.ReadLine();


Rectangle found = null;
foreach (Rectangle rect in rects)
{
    if (rect.Name == entry)
    {
        found = rect;
        break;
    }
}

if (found != null)
{
    Console.WriteLine(found);
}
else
{
    Console.WriteLine("Sorry, not found.");
}

class Rectangle
{
    public string Name;
    public double Length;
    public double Height;

    public Rectangle(string _name, double _length, double _height)
    {
        Name = _name;
        Length = _length;
        Height = _height;
    }

    public override string ToString()
    {
        return $"{Name}: {Length}x{Height},  Area = {Length}*{Height}";
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();

    }
}