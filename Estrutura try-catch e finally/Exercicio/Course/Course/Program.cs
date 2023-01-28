using Course.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {   //LOGICA RUIM - LOGICA DE VALIDACAO DA RESERVA NO PROGRAMA PRINCIPAL//
        // LOGICA DE VALIDACAO NAO DELEGADA A RESERVA //
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be futures dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }

                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);

                }


            }


        }
    }
}