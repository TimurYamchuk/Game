class Race
{
    private List<Car> cars;
    private bool isRaceOngoing;
    private Car raceWinner;

    public delegate void RaceEvent();
    public event RaceEvent RaceStarted;
    public event EventHandler<string> RaceFinished;

    public Race()
    {
        cars = new List<Car>();
        isRaceOngoing = false;
    }

    public void RegisterCar(Car car)
    {
        car.Finished += OnCarFinished;
        car.PositionUpdated += OnPositionUpdated;
        cars.Add(car);
    }

    public void BeginRace()
    {
        Console.WriteLine("Гонка начнется через 3 секунды! Подготовьтесь...\n");

        RaceStarted?.Invoke();

        Thread.Sleep(3000);

        isRaceOngoing = true;

        while (isRaceOngoing)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("          Гонка началась!          ");
            Console.WriteLine("=====================================");

            // Двигаем и отображаем все машины
            foreach (var car in cars)
            {
                car.Drive();
                car.Render(); // Отображение машины в новой позиции
            }

            Thread.Sleep(200); // Задержка, чтобы анимация была видна
        }
    }

    private void OnPositionUpdated(object sender, EventArgs e)
    {
        // Этот метод будет вызван при обновлении позиции
    }

    private void OnCarFinished(object sender, EventArgs e)
    {
        if (sender is Car car && isRaceOngoing)
        {
            isRaceOngoing = false;
            raceWinner = car;

            Console.Clear();
            RaceFinished?.Invoke(this, $"Победитель гонки: #{raceWinner.Number} - {raceWinner.Name}");
        }
    }
}