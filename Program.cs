using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
/***
 * THIS IS A BUS SIMULATOR PROGRAM
 * EVERY NUMBER HERE IS RANDOMLY  GENERATED
 * 
 * AUTHOR: MITCHELL ANINYANG
 */
namespace bussimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t BUS SIMULATOR \t\n" +
                "\t-----BY MITCHELL ANINYANG-----");

            Random random = new Random();
            bus bus = new bus();                            //create instance of the bus class
            busStop busStop = new busStop();                //create instance of the busStop class

            int busStops = bus.getbusStops();               //total number of bus stops on that route
            int remBusStops = busStops;                     //total number of remaining bus stops 
            int pastBusStops = busStops - remBusStops;      //number of past bus stops
            int passengerCount = bus.getPassengerCount();   //number of passengers on board

            Console.WriteLine($"\t\r\nNumber of Bus stops on route: {busStops}\n");
            /*
             * create a for loop 
             */
            for (int i = 0; i <= busStops; i++)
            {

                bool isPerson = false;                              //boolean flag to control if there are people at the busstop
                bool isdropping = false;                            //boolean flag to control of there are people dropping dropping

                int comingPossibility = random.Next(2);             //this is what i call a random flag
                                                                    //to generate a random number and use it to determine what to do based on 
                                                                    //what the random number is
                int droppingPossibility = random.Next(5);
                int humansComing = random.Next(8);                   //humans at the busStop
                int humansDropping = random.Next(passengerCount);    //humans 

                if (i == busStops)
                {
                    //bunch of print statements
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nNumber of Bus Stops Remaining --\t {busStops - i}");
                    Console.ForegroundColor = System.ConsoleColor.Cyan;
                    Console.WriteLine($"Number of Passengers --\t {passengerCount}");

                    humansComing = 0;
                    humansDropping = passengerCount;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Number of passengers dropping -- {humansDropping}");
                    break;
                }

                //bunch of print statements
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nNumber of Bus Stops Remaining --\t {busStops - i}");
                Console.ForegroundColor = System.ConsoleColor.Cyan;
                Console.WriteLine($"Number of Passengers --\t {passengerCount}");


                if (comingPossibility == 0)
                {
                    isPerson = false;
                    if (droppingPossibility == 0 || droppingPossibility == 1 || droppingPossibility == 2 || droppingPossibility == 3)
                    {
                        isdropping = false;
                    }
                    else
                    {
                        if (passengerCount == 0)
                        {
                            isdropping = false;
                            humansDropping = 0;
                        }
                        else
                        {
                            isdropping = true;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Number of passengers dropping -- {humansDropping}");
                            passengerCount -= humansDropping;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Nobody at next bus stop -- Press any key to continue");
                    Console.ReadLine();
                }
                else
                {
                    isPerson = true;
                }
                if (isPerson == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Number of humans at next bus stop: {humansComing}\n" +
                        $"press any key to stop");
                    Console.ReadLine();
                    passengerCount += humansComing;
                    
                }
                
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You have reached the end of your trip!");
            Console.ReadLine();
        }

    }
}
