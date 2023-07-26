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

bool Yesno = false;
Car match = Allcar.FirstOrDefault(x => x.Model.ToLower() == choice);
Console.WriteLine(match.ToString());
Console.WriteLine("");
Console.WriteLine("Would you like to buy this car? y/n");
string yn = Console.ReadLine().ToLower().Trim();


if (yn == "y")
{
    Allcar.Remove(match);
}
else
{

}

foreach (Car i in Allcar)
{
    Console.WriteLine(i);
}

Console.WriteLine("Would you like to list a car ");


