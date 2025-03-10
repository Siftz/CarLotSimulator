﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            CarLot carLot = new CarLot(); 
//car 1 set up
            Car car1 = new Car
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Corolla",
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");
            
            //car1.MakeEngineNoise();
            //car1.MakeHonkNoise();
//car 2 setup
            Car car2 = new Car();
            car2.Year = 2021;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Zoom";
            car2.HonkNoise = "Honk";
            car2.IsDriveable = true;
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");
            //car2.MakeEngineNoise();
            //car2.MakeHonkNoise();
//car 3 set up
            Car car3 = new Car();
            car3.Year = 2022;
            car3.Make = "Ford";
            car3.Model = "Mustang";
            car3.EngineNoise = "Roar";
            car3.HonkNoise = "Toot";
            car3.IsDriveable = true;
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");
            //car3.MakeEngineNoise();
            //car3.MakeHonkNoise(); //commented out sounds for updated exercise

            carLot.Cars.Add(car1);
            carLot.Cars.Add(car2);
            carLot.Cars.Add(car3);

            foreach (Car car in carLot.Cars) //foreach loop for the cars to go through
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}