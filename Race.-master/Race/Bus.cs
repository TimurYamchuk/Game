class Bus : Car
{
    public Bus(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

    public override void AdjustSpeed()
    {
        Speed = random.Next(25, 80); 
    }

    public override void Render()
    {
        int carPosition = (int)(Position / FinishDistance * 50);  
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{new string(' ', carPosition)}[B] #{Number} ({Name})");
        Console.ResetColor();
    }
}

