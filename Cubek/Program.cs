using System;

class Cube
{
    public double Sidelenght { get; set; }

    public Cube(double sidelenght)
    {
        Sidelenght = sidelenght;
    }


    public double Volume()
    {
        return Math.Pow(Sidelenght, 3);
    }

    public double Area()
    {
        return 6 * Math.Pow(Sidelenght, 2);
    }
}

class Program
{
    static void Main()
    {
        Cube calculate = new Cube(5);
        Console.WriteLine("Об'єм: " + calculate.Volume());
        Console.WriteLine("Площа: " + calculate.Area());
    }
}

