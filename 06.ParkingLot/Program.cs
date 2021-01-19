using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string[] arr = Console.ReadLine().Split(", ");

            while (arr[0] != "END")
            {
                if (arr[0] == "IN")
                {
                    cars.Add(arr[1]);
                }
                else if (arr[0] == "OUT")
                {
                    cars.Remove(arr[1]);
                }

                arr = Console.ReadLine().Split(", ");
            }

            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
