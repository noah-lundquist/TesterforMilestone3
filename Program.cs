using System;
using System.Collections.Generic;
using System.Linq;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cars = { "2013 Tesla Model S 89000", "2020 Lamborghini Huracan 2200000", "2015 Honda Civic 15000" };

            //this will be a method called in the final program

            string newCar = "2009 Porsche 911 25000";//will be pulled in via textbox
            List<string> list = new List<string>(cars.ToList());
            list.Add(newCar);
            cars = list.ToArray();
            Console.WriteLine("Your new car added is" + newCar);

            Console.WriteLine("All current Inventory");

            foreach (var e in cars)
            {
                Console.WriteLine(e);
            }

            //Will be put into method
            int pos = 3;//the position will be equal to the part number
            int i;
            for (i = pos - 1; i < 3; i++)
            {
                cars[i] = cars[i + 1];
            }
            Console.WriteLine("Inventory after sold car");

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //to re add you will have to reenter the cars details, so this will be identical to the add method
            string readdCar = "2018 Mclaren 720s 600000";//will be pulled in via textbox
            
            list.Add(readdCar);
            cars = list.ToArray();
            Console.WriteLine("Your new car added is" + newCar);

            Console.WriteLine("All current Inventory after new car added");

            foreach (var e in cars)
            {
                Console.WriteLine(e);
            }

            // the position of the array will correspond with the part number
            // this will also be in a method

            string findByPartNumber = cars[1];

            Console.WriteLine("Searching");
            Console.WriteLine(findByPartNumber);

            string search = "Mclaren";
            string Mclaren = "Mclaren";
            string Lambo = "Lamborghini";
            string honda = "honda";
            string tesla = "tesla";
            
            if (search == Mclaren)
            {
                Console.WriteLine("You were searching for a 2018 Mclaren 720s 600000");
            }
            if (search == Lambo)
            {
                Console.WriteLine("You were searching for a 2020 Lamborghini Huracan 2200000");
            }
            if (search == honda)
            {
                Console.WriteLine("You were searching for a 2015 Honda Civic 15000");
            }
            if (search == tesla)
            {
                Console.WriteLine("2013 Tesla Model S 890000");
            }


            //method to return car by partnum partnum will be equal to the position in the array

            Console.WriteLine("The car your searching for is " + cars[2]);
        }









    }
}