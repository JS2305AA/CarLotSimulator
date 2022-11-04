﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();
            bmw.Year = 2016;
            bmw.Make = "BMW";
            bmw.Model = "328i";
            bmw.EngineNoise = "Vroom";
            bmw.HonkNoise = "Beep Beep";
            bmw.IsDriveable = true;

            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();

            Car celica = new Car() { Year = 2000, Make = "Toyota", Model = "Celica", EngineNoise = "Nothing", HonkNoise = "Help" };

            celica.MakeEngineNoise();
            celica.MakeHonkNoise();

            Car someOtherCar = new Car(3000, "Mars Inc.", "Alpha", "Space Noises", "Does a space ship honk");

            someOtherCar.MakeEngineNoise();
            someOtherCar.MakeHonkNoise();

            Console.WriteLine("--------");

            var lot = new CarLot();

            lot.CarList = new List<Car>() { bmw, celica, someOtherCar };

            //BONUS for class CarLot.cs
            foreach(var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year : {car.Year} Make : {car.Make} and Model : {car.Model}");
            }

            
            
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
        }
    }
}
