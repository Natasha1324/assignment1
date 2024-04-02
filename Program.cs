using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_No._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctusername = "Keisha Herrera";
            string correctpassword = "Keisha1234";
            int attemps = 3;
            while (attemps > 0) 
            {
                Console.Write("Input username: ");
                string username = Console.ReadLine();
                Console.Write("Input password: ");
                string password = Console.ReadLine();

                if (username == correctusername && password == correctpassword)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username/password. Please try again!");
                    attemps--;
                    Console.WriteLine($"You have {attemps} attempts left!");
                }
            }
            if (attemps == 0)
            {
                Console.WriteLine("You have reached the maximum no. of attemps. Please try again later!");
            }
        }
    }
}
