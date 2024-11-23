class Sedan : Car
{
    public Sedan(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

    public override void AdjustSpeed()
    {
        Speed = random.Next(40, 70); // Пример диапазона скорости для седана
    }

    public override void Render()
    {
        int carPosition = (int)(Position / FinishDistance * 50);  // Машина двигается по экрану
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{new string(' ', carPosition)}[O] #{Number} ({Name})");
        Console.ResetColor();
    }
}