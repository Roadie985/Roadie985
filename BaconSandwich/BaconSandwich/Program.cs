using System;

namespace BaconSandwich
{
    class Program
    {
        static void Main(string[] args)
        {
           


                Console.WriteLine("Do you want a bacon sandwich?");
                Console.Write("Yes or no? ");
                var ans1 = Console.ReadLine();
                var ansshow = ans1.ToString();


                Console.WriteLine(ansshow +" WAS YOUR GIVEN ANSWER");
                if (ans1 == "YES")
                {
                    
                    Console.WriteLine("Good choice");
                   
                }
            if (ans1 == "NO")
            {

                Console.WriteLine("Oh yes you do");

            }

        }
          
        
    }
}
