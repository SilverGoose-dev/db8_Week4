using System.Threading.Tasks;
// Desiplay list of 6 cars, 3 used and 3 new. Along with Add car and quit. 
// Let user select car for purchase, if yes, remove it to the list. 
// If user wants to add another car, add it to the data collection
//Keep looping until they close. 

//Car class
//-- string make, --string model, --int year, --decimal price
//New Car
//Used Car
List<Car> carlist = new List<Car>();
ListInit(carlist);

while (true)
{
    Console.Clear();
    string choice = PrintMenuGetChoice(carlist).ToLower();
    if (choice == "sell")
    {
        Sell(carlist);
    }
    else if (choice == "quit" || choice == "q")
    {
        Thread.Sleep(500);
        Console.WriteLine("Good-bye!");
        break;
    }
    else
    {
        int index = int.Parse(choice) -1;
        Buy(carlist, index);
    }
}


static void Sell(List<Car> thelist)
{
    Thread.Sleep(1000);
    Console.WriteLine("Please give us the details about your car.");
    string condition = "Used";
    Thread.Sleep(1000);
    Console.Write("Make:  ");
    string make = Console.ReadLine();
    Console.Write("Model:  ");
    string model = Console.ReadLine();
    Console.Write("Year:  ");
    string year = Console.ReadLine();
    Console.Write("Mileage:  ");
    string mileage = Console.ReadLine();
    Console.Write("How much are you looking to get:  ");
    string price = Console.ReadLine();

    thelist.Add(new UsedCar(condition, Convert.ToInt32(year), make, model, Convert.ToDecimal(price), Convert.ToDouble(mileage)));

    Console.WriteLine("\nThanks, we are the dumbest lot around and will give the sellers exactly how much they want!");
    Thread.Sleep(3000);

}

static void Buy(List<Car> thelist, int index)
{
    Thread.Sleep(1000);
    Console.WriteLine("Is this the car you want to buy?");
    Console.WriteLine(thelist[index]);
    Console.Write("Y/N: ");
    string yesno = Console.ReadLine().ToLower();
    if (yesno == "y" || yesno == "yes")
    {
        thelist.RemoveAt(index);
        Console.WriteLine("Item Purchased!");
        Thread.Sleep(1000);
    }
    else
    {
        Console.WriteLine("Thanks anyway!");
    }
}


static void ListInit(List<Car> thelist)
{
    thelist.Add(new Car("New", 2022, "Jeep", "Wrangler", 55000m));
    thelist.Add(new Car("New", 2022, "Ford", "Fusion", 29000m));
    thelist.Add(new Car("New", 2022, "Dodge", "Ram 1500", 65999m));
    thelist.Add(new UsedCar("Used", 2019, "Jeep", "Cherokee", 25000m, 45000));
    thelist.Add(new UsedCar("Used", 1983, "Delorean", "DMC-12", 212000m, 25000));
    thelist.Add(new UsedCar("Used", 2004, "Chevy", "S10", 8000m, 165000));
}
static string PrintMenuGetChoice(List<Car> thelist)
{
    Console.WriteLine("Please choose a car for purchase or other options:");
    for (int index = 0; index < thelist.Count; index++)
    {
        Car car = thelist[index];
        Console.WriteLine($"{index + 1}: {car}");
    }
    Console.WriteLine("\n-Sell");
    Console.WriteLine("-Quit");
    Console.Write("Your choice:  ");
    string entry = Console.ReadLine();
    return entry;

}





class Car
{
    public string condition;
    public int year;
    public string make;
    public string model;
    public decimal price;

    public Car(string _condition, int _year, string _make, string _model, decimal _price)
    {
        condition = _condition; 
        make = _make;
        model = _model;
        year = _year;
        price = _price;
    }

    public override string ToString()
    {
        return string.Format($"{year} {make} {model}  ${price} ({condition})");
    }
}
class UsedCar : Car
{
    public double mileage;

    public UsedCar(string _condition, int _year, string _make, string _model, decimal _price, double _mileage)
        :base(_condition, _year, _make, _model, _price)
    {
        mileage = _mileage;
    }

    public override string ToString()
    {
        return string.Format($"{year} {make} {model} ${price}  {mileage} miles. ({condition}) ");
    }
}