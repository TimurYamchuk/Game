using System;
using System.Collections.Generic;
using System.Threading;

abstract class Car
{
    public event EventHandler Finished;
    public event EventHandler PositionUpdated;

    public double Speed { get; set; }
    public string Name { get; private set; }
    public int Number { get; private set; }
    public double Position { get; protected set; } = 0;
    protected double FinishDistance { get; set; } = 100.0;
    protected Random random = new Random();

    public Car(string name, double initialSpeed, int num)
    {
        Name = name;
        Speed = initialSpeed;
        Number = num;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"#{Number} - {Name}: Позиция {Position:F1}, Скорость: {Speed:F1}");
    }

    public void Drive()
    {
        Position += Speed * 0.1;
        if (Position >= FinishDistance)
        {
            Position = FinishDistance;
            OnFinished();
        }
        else
        {
            PositionUpdated?.Invoke(this, EventArgs.Empty);
        }
    }

    public virtual void AdjustSpeed()
    {
        Speed = random.Next(30, 100);
    }

    protected virtual void OnFinished()
    {
        Finished?.Invoke(this, EventArgs.Empty);
    }

    // Упрощенная визуализация движения машины
    public abstract void Render();
}