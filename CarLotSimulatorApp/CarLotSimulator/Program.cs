using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car DONE!!!!!!!
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable DONE!!!!!
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() DONE!!!!!
            //The methods should take one string parameter: the respective noise property DONE!!!!!!


            //Now that the Car class is created we can instanciate 3 new cars DONE!!!!
            //Set the properties for each of the cars DONE!!!!!!!
            //Call each of the methods for each car Done!!!!!

            CarLot instance = new CarLot();
            

            Car car1 = new Car(); 
            car1.Make = "Acrua";
            car1.Model = "MDX Type S";
            car1.Year = 2025;
            car1.EngineNoise = "VROOOM";
            car1.HonkNoise = "beep beep";
            car1.IsDriveble = true;
            instance.ListOfCars.Add(car1);

            Car car2 = new Car() {Make = "Lexus", Model = "RX 350 F Sport", EngineNoise = "VROOOOM", HonkNoise = "beep beep", Year = 2025, IsDriveble = true}; 
            

            Car car3 = new Car("Mercedes-Benz", "AMG GLE 63 S Coupe", 2025, "VROOOOOOOOM", "beep beep", true);

            instance.ListOfCars.Add(car1);
            instance.ListOfCars.Add(car2);
            instance.ListOfCars.Add(car3);

            foreach (Car item in instance.ListOfCars) 
            { 
                Console.WriteLine($"{item.Make}");
                Console.WriteLine($"{item.Model}");
                Console.WriteLine($"{item.Year}");
                Console.WriteLine($"{item.EngineNoise}");
                Console.WriteLine($"{item.HonkNoise}");
                Console.WriteLine($"{item.IsDriveble}");
                Console.WriteLine();
                Console.WriteLine();
            }
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
