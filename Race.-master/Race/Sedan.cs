class Sedan : Car
{
    public Sedan(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

    public override void AdjustSpeed()
    {
        Speed = random.Next(40, 70); 
    }

    public override void Render()
    {
        int carPosition = (int)(Position / FinishDistance * 50);  
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{new string(' ', carPosition)}[O] #{Number} ({Name})");
        Console.ResetColor();
    }
}
