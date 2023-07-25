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
