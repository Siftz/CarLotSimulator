namespace CarLotSimulator;
using System.Collections.Generic;

public class CarLot
{
    public static int numberOfCars = 0; //static field to track number of cars
    public List<Car> Cars { get; set; } = new List<Car>();
}