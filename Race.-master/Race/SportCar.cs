class SportCar : Car
{
    public SportCar(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

    public override void AdjustSpeed()
    {
        Speed = random.Next(50, 150); // Спортивная машина движется быстрее
    }

    public override void Render()
    {
        int carPosition = (int)(Position / FinishDistance * 50);  // Машина двигается по экрану
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{new string(' ', carPosition)}[F] #{Number} ({Name})");
        Console.ResetColor();
    }
}