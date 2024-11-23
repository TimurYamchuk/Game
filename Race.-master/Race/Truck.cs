﻿class Truck : Car
{
    public Truck(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

    public override void AdjustSpeed()
    {
        Speed = random.Next(20, 70); // Грузовик движется медленнее
    }

    public override void Render()
    {
        int carPosition = (int)(Position / FinishDistance * 50);  // Машина двигается по экрану
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{new string(' ', carPosition)}[T] #{Number} ({Name})");
        Console.ResetColor();
    }
}