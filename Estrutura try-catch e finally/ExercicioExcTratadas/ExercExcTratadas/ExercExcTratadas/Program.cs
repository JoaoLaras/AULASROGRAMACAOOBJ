using Course.Entities;
using ExercExcTratadas.Entities.Exceptions;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainExceptions a)
            {
                Console.WriteLine("Error in reservation: " + a.Message);
            }

            catch (FormatException b)
            {
                Console.WriteLine("Format error: " + b.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Unexpcted error: " + e.Message);
            }



        }
    }
}