using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace textAdventure
{
    public class Health
    {
        public static int x { get; set; } = 4; // property for variable int x
        public static void Start() //starts the health tracking
        {
            if(x <= 4)
            {
                Console.WriteLine($"Your health is {x}");
            }   
            else if(x == 0)
            {
                Console.WriteLine($"Sorry! You died :(\n Your health is {x}");
            }
             
        }
        public static void Status() //gives status of health through program
        {
            if (x == 4)
            {
                Console.WriteLine($"Your health is hearts : {x}");
            }
            
        }


       
        public  static void  LoseHealth( ) //decrement health
        {
            --x;
        }

        public static void GainHealth() //increment health
        {
            ++x;
        }

        public static void End() //gives ending health total
        {
            Console.WriteLine($"Your final health is: {x}");
        }



           
            


    }

}
