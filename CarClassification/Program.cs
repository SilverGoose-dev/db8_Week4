Sedan mycar = new Sedan(4, "Blue", true, 4);
mycar.Drive();

Racecar myracecar = new Racecar(4, "Red", 400);
myracecar.Drive();



class Vehicle
{
    public int wheelCount;
    public string color;
    
    public Vehicle(int _wheelCount, string _color)
    {
        wheelCount = _wheelCount;
        color = _color;
    }
    public virtual void Drive()
    {
        Console.WriteLine($"I am driving a {color} car with {wheelCount} wheels");
    }

}


class Sedan : Vehicle
{
    public bool hasHatchback;
    public int doorCount;

    public Sedan(int _Sedanwheelcount, string _Sedancolor, bool _hasHatchback, int _doorCount) : base(_Sedanwheelcount, _Sedancolor)
    {
        hasHatchback = _hasHatchback;
        doorCount = _doorCount;
    }
    public override void Drive()
    {
        Console.WriteLine($"I am driving speed-limit in my {doorCount} door car");
    }
}

class Racecar : Vehicle
{
    public int engineSize;

    public Racecar(int _WheelCount, string _Color, int _EngineSize)
        :base(_WheelCount, _Color)

    {
        engineSize = _EngineSize;
    }
    public override void Drive()
    {
        Console.WriteLine($"I am going hella fast in my {engineSize} engine!");
    }

}