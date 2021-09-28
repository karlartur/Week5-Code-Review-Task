using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string password = Console.ReadLine();
            /* if (userName == "admin" && password == "admin1234")
             {
                 Console.WriteLine("Tere tulemast!");
             }
             else
             {
                 Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuesti.");
             }*/
            if (userName != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
