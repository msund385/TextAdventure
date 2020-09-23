using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace textAdventure
{
    using System;

  
    internal class Flow1
    {
       
       //Scene1--Scene3-Scene5-Scene7
       //Scene1--Scene2--Scene4--Scene6
        public static void Scene1()
        {
            Console.WriteLine("So you got away from the wild boars,\n you stop to relax and check your wounds");
            Console.WriteLine("You see bandages laying in the distance or Gold in the other direction : 1. Bandage 2. Gold.");
            string gold = Console.ReadLine();
            var w = 0;
            Int32.TryParse(gold, out w);
            if (w == 1)
            {
               Scene2();
            }
            else if (w == 2)
            {
                Scene3();
            }
            while(true)
            {
               
            }
            
        }
          
        public static void Scene2()
        {
            Console.WriteLine("You have survived thus far, you will be rewarded!!!");
            Console.WriteLine("What is your dog's name?");
            string duck  = Console.ReadLine();
            Scene4();
        }
        

        
            
           
            
           
            
                
            
            
            

        public static void Scene3()
        {
            Console.WriteLine("You want those riches,get that Money, here's some advice from Warren");
            Console.WriteLine("Only buy something that you’d be perfectly happy to hold \nif the market shuts down for ten years.”");
            Console.WriteLine("Any thing in the world,what is it...");
            string prize = Console.ReadLine();
            var d = 1;
            Scene5();

           
            
                
            

          
            

            
        }
        public static void Scene4()
        {   Console.WriteLine($"Your dog's name is (Scene2.duck)");
            Console.WriteLine("Your dog leads you to a make shift shack in the distance ");
            Scene6();


        }

        public static void Scene5()
        {
            Console.WriteLine ("Your (prize) is weighing you down, you stumble then take a seat next to an old oak tree");
            Console.WriteLine("You are feeling weak, you cant eat (prize) , you pass out");
            Scene7();

        }

        public static void Scene6()
        {
            Console.WriteLine("You walk up , pull on the door, it opens....");
            Console.WriteLine("You and (duck) walk in, sitting in the chair is (Program.friend)");
            Console.WriteLine("(Program.friend) lead you to safety, you win a cruise and vacation from the ruff life");
            System.Environment.Exit(0);
        }

         public static void Scene7()
        {
            Console.WriteLine("You awaken from a tap on the shoulder, it's your buddy(Program.friend)");
            Console.WriteLine("They give you nourishment and help you carry the gold and (prize)");
            Console.WriteLine("You recover and with your share of Gold and (prize) you bought a BW3 franchise");
            System.Environment.Exit(0);
        }




    }
}
       

    
    
    







    
   
    
    

    
    
    
    
    

   
    
    
 

   

    
 


    

    
    
    
    
    
    

