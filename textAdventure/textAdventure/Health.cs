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
        public static int x { get; set; } = 2; // property for variable int x
        public static void Start() //starts the health tracking
        {
            if(x <= 2)
            {
                Console.WriteLine($"Your health is {x} hearts");
            }   
            else if(x <= 0)
            {
                End();
            }
             
        }
        public static void Status() //gives status of health through program
        {
            if (x >= 0)
            {
                Console.WriteLine($"Your health is {x} hearts!");
            }
            else
            {
                Console.WriteLine("You Dead!!!!\n You ran out of steam,luckily your heirs collect the goods");
                System.Environment.Exit(0);
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
            if (x <= 0)
            {
                Console.WriteLine("You Dead!!!!\n You ran out of steam,luckily your heirs collect the goods");
            }
            else
            {
                Console.WriteLine($"Your final health is {x} hearts");
            }

        }



           
            


    }

}
