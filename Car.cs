class Car : Vehicle
{
    private int passengerCapacity;
    private double fuelConsumption;

    public int PassengerCapacity
    {
        get { return passengerCapacity; }
        set
        {
            if (value < 1 || value > 9)
            {
                throw new ArgumentException("Количество пассажиров в легковом автомобиле должно быть от 1 до 9");
            }

            passengerCapacity = value;
        }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Расход топлива должен быть больше 0");
            }

            fuelConsumption = value;
        }
    }

    public Car(string brand, string model, int year, double speed,
               int passengerCapacity, double fuelConsumption)
        : base(brand, model, year, speed)
    {
        PassengerCapacity = passengerCapacity;
        FuelConsumption = fuelConsumption;
    }

    public void OpenTrunk()
    {
        Console.WriteLine(Brand + " " + Model + ": багажник открыт");
    }
}
