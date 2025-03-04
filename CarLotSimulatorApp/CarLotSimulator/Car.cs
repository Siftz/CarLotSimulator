namespace CarLotSimulator;
using System;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public Car() // Constructor to increment each time a car is made
    {
        CarLot.numberOfCars++;
    }

    public void MakeEngineNoise()
    {
        Console.WriteLine(EngineNoise);
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine(HonkNoise);
    }
}