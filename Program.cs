using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Inlamningsuppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = false;
            bool backTop = true;
            while (backTop)
            { 
            

            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine("Välkommen till Gustav's miniräknare");

            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an operator");
            string opt = Console.ReadLine();
            Console.WriteLine("enter another number");
            int b = Convert.ToInt32(Console.ReadLine());



            int result = 0;

            if (opt == "+")
            {
                result = a + b;
                Console.WriteLine("Answer is : " + result);
                answer = true;

            }
            else if (opt == "-")
            {
                result = a - b;
                Console.WriteLine("Answer is : " + result);
                answer = true;
            }
            else if (opt == "*")
            {
                result = a * b;
                Console.WriteLine("Answer is : " + result);
                answer = true;
            }
            else if (opt == "/")
            {
                result = a / b;
                Console.WriteLine("Answer is : " + result);
                answer = true;

            }

            if (answer == true)
            {
                Console.WriteLine("Do you want to restart your calculation? yes/no");
                string restart = Console.ReadLine();

                if (restart == "yes")
                {
                        backTop = true;
                }


            }

            }
            Console.WriteLine("test commit2");

            Console.Read();
        }
        
    }
}
