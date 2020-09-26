﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.Diagnostics;
using System.Drawing;


namespace textAdventure
{
    class Program
    {
        public static string Pick { get; set; } 
        public static string Friend { get; set; }
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;// changes console to red/cyan
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hi, welcome to your text adventure,choose your fate");
            Health.Start();
            Console.WriteLine("What is the name of our courageous hero?");
            string hero = Console.ReadLine(); //stores user input
            Console.WriteLine("What is the name of your brave friend");
            Friend = Console.ReadLine(); //stores user input
            Console.WriteLine("What is your dazzling magic?");
            string magic = Console.ReadLine(); //stores user input
            Console.WriteLine($"Welcome to the land of Cheyenia, where {hero} lives,breathes and");
            Console.WriteLine($"survives with his pal {Friend}.You must use your power of {magic}");
            Console.WriteLine("to save the citizens from destruction. May the swartz be with you!!!");
            
            Console.WriteLine("Do you go right or left,\n enter: 1.right or 2.left!!!!");
            Pick = Console.ReadLine();//assigns user input to a variable
                
            int x = 0;
            Int32.TryParse(Pick, out x);//changes string to int
               
            if (x == 1)//takes answer 1 or 2 and supplies corresponding answer
            {
                Console.WriteLine("Bad Choice!!You find yourself in the woods, \n you ran into a pack of wild boars!! You got bitten");
                Health.LoseHealth();
                Flow1.Scene1();
            }
            else if (x == 2)
            {
                    Console.WriteLine("Good choice!! You hit a clearing and found a water source.\n You get some relaxation time and ponder your next move");
                    Health.GainHealth();
                    Flow1.Scene2();
            }
               

        }


    }
       


}










                
                
                

        
       
            
        






















        











            
    
           

                  



                
    
            
               
                

                
                    




            
            

        









           





   

        
            
            
            
            
        
       

        





   








  



   
                  
            






  
        
        
        


       
  




        
            
            
            
      























































    
    




    

    
    

