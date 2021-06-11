using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare String Array/ Int Array / and String List
            string[] vehicleType = new string[] { "Car", "Truck", "SUV", "Van" };
            int[] vehicleYear = new int[] { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021 };
            List<string> vehicleMake = new List<string>() { "Ford", "Dodge", "Chevy"};

            //intro
            Console.WriteLine("Welcome to a thing that shows you your car. \n");

            //user display/input
            Console.WriteLine("Please select a vehicle type: ");
            Console.WriteLine("1. CAR ");
            Console.WriteLine("2. TRUCK ");
            Console.WriteLine("3. SUV ");
            Console.WriteLine("4. VAN ");
            int userVehicleType = Convert.ToInt32(Console.ReadLine());

            //output selection
            switch(userVehicleType)
            {
                case 1:
                    Console.WriteLine(vehicleType[0]);
                    break;

                case 2:
                    Console.WriteLine(vehicleType[1]);
                    break;

                case 3:
                    Console.WriteLine(vehicleType[2]);
                    break;

                case 4:
                    Console.WriteLine(vehicleType[3]);
                    break;

                default:
                    Console.WriteLine("This is not a valid option.");
                    break;
            }

            //user display/input
            Console.WriteLine("Please select a vehicle year: ");
            Console.WriteLine("1. 2010 ");
            Console.WriteLine("2. 2011 ");
            Console.WriteLine("3. 2012 ");
            Console.WriteLine("4. 2013 ");
            Console.WriteLine("5. 2014 ");
            Console.WriteLine("6. 2015 ");
            Console.WriteLine("7. 2016 ");
            Console.WriteLine("8. 2017 ");
            Console.WriteLine("9. 2018 ");
            Console.WriteLine("10. 2019 ");
            Console.WriteLine("11. 2020 ");
            Console.WriteLine("12. 2021 ");
            int userVehicleYear = Convert.ToInt32(Console.ReadLine());

            //output selection
            switch (userVehicleYear)
            {
                case 1:
                    Console.WriteLine(vehicleYear[0]);
                    break;

                case 2:
                    Console.WriteLine(vehicleYear[1]);
                    break;

                case 3:
                    Console.WriteLine(vehicleYear[2]);
                    break;

                case 4:
                    Console.WriteLine(vehicleYear[3]);
                    break;

                case 5:
                    Console.WriteLine(vehicleYear[4]);
                    break;

                case 6:
                    Console.WriteLine(vehicleYear[5]);
                    break;

                case 7:
                    Console.WriteLine(vehicleYear[6]);
                    break;

                case 8:
                    Console.WriteLine(vehicleYear[7]);
                    break;

                case 9:
                    Console.WriteLine(vehicleYear[8]);
                    break;

                case 10:
                    Console.WriteLine(vehicleYear[9]);
                    break;

                case 11:
                    Console.WriteLine(vehicleYear[10]);
                    break;

                case 12:
                    Console.WriteLine(vehicleYear[11]);
                    break;

                default:
                    Console.WriteLine("This year is not eligable for our program.");
                    break;
            }

            //user display/input
            Console.WriteLine("Please select a vehicle model: ");
            Console.WriteLine("1. Ford ");
            Console.WriteLine("2. Dodge ");
            Console.WriteLine("3. Chevy ");
            int userVehicleMake = Convert.ToInt32(Console.ReadLine());

            //output selection
            switch (userVehicleMake)
            {
                case 1:
                    Console.WriteLine(vehicleMake[0]);
                    break;

                case 2:
                    Console.WriteLine(vehicleMake[1]);
                    break;

                case 3:
                    Console.WriteLine(vehicleMake[2]);
                    break;

                default:
                    Console.WriteLine("This is not a valid option.");
                    break;
            }

            Console.Read();
        }
    }
}   
