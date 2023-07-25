using Used_Car_Lot_Lab;

Console.WriteLine("Welcome to Grand circus Car Lot.");
List<Car> Allcar = new List<Car>()
{
    new Car ("Chevrolet", "Corvette", 2023, 90000),
    new Car("Chevrolet", "Blazer", 2023, 50000),
    new Car("Ford", "F150", 2023, 80000),
    new UserCar("Ford", "Expedition",2014, 10500.99m,180000),
    new UserCar("Kia", "Soul", 2008, 800,2000),
    new UserCar("Ford", "Mustang", 2009, 8000,50000)
};

foreach (var car in Allcar)
{
    Console.WriteLine(car);
}

Console.WriteLine("Which car do you want to buy?");
string choice = Console.ReadLine().ToLower().Trim();
//bool Found = Allcar.Any(x => x.Model.ToLower() == choice); 
if (Allcar.Any(x => x.Model.ToLower() == choice))
    { 

    }
//(Allcar.Any(x => x.Model.ToLower() = choice))
    //{
    //Console.WriteLine();
    //}
//string indx = Allcar.FindIndex(s => s == choice);

//while (int.TryParse(Console.ReadLine(), out choice) == false)





List<Car> MakerList = Allcar.Where(c => c.Make.ToLower() == choice).ToList();






string name = "bob";
List<string> names = new List<string> { "dood", "tom", "doddl", "bob", "toby" };

