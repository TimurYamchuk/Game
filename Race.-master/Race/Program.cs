class Program
{
    static void Main(string[] args)
    {
        Race race = new Race();

        race.RaceStarted += () => Console.WriteLine("Гонка началась!");
        race.RaceFinished += (sender, winner) => Console.WriteLine(winner);

        // Регистрация автомобилей
        race.RegisterCar(new Sedan("Sedan", 40, 1));
        race.RegisterCar(new Truck("Truck", 30, 2));
        race.RegisterCar(new Bus("Bus", 35, 3));
        race.RegisterCar(new SportCar("SportCar", 60, 4));

        // Начало гонки
        race.BeginRace();
    }
}