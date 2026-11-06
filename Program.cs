Console.OutputEncoding = System.Text.Encoding.UTF8;

Car car = new Car("Toyota", "Camry", 2020, 0, 5, 8.5);
Truck truck = new Truck("KAMAZ", "5490", 2019, 0, 20000);
Bus bus = new Bus("MAN", "Lion's City", 2021, 0, 40);

Console.WriteLine("=== Легковой автомобиль ===");
car.DisplayInfo();
Console.WriteLine("Пассажиров: " + car.PassengerCapacity);
Console.WriteLine("Расход на 100 км: " + car.FuelConsumption + " л");
car.OpenTrunk();
Console.WriteLine();

Console.WriteLine("=== Грузовой автомобиль ===");
truck.DisplayInfo();
Console.WriteLine("Грузоподъёмность: " + truck.LoadCapacity + " кг");
truck.LoadCargo(12000);
truck.LoadCargo(5000);
truck.LoadCargo(5000);
truck.LoadCargo(-100);
Console.WriteLine();

Console.WriteLine("=== Автобус ===");
bus.DisplayInfo();
Console.WriteLine("Мест: " + bus.SeatsCount);
bus.BoardPassengers(25);
bus.BoardPassengers(10);
bus.BoardPassengers(10);
bus.BoardPassengers(0);
Console.WriteLine();

Console.WriteLine("=== Проверка запуска двигателя (метод из Vehicle) ===");
car.StartEngine();
truck.StartEngine();
bus.StartEngine();
Console.WriteLine();

Console.WriteLine("=== Проверка некорректных данных ===");

try
{
    Car wrongCar = new Car("Lada", "Granta", 2020, 0, 20, 7);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}

try
{
    Truck wrongTruck = new Truck("MAZ", "6430", 2018, 0, -500);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}

try
{
    Bus wrongBus = new Bus("Ikarus", "256", 1990, 0, 0);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}
