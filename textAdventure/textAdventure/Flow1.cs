using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System;
using TextAdventure;

namespace textAdventure
{
    


    internal class Flow1 : Health

    {
        public static string Duck{ get; set; } //property creates Duck
        public static string Prize { get; set; } //property creates Prize

       
     //Scene1--Scene3-Scene5-Scene7
     //Scene1--Scene2--Scene4--Scene6
     public static void Scene1() //2nd set of questions
     {
         Console.ForegroundColor = ConsoleColor.Yellow;// changes console to red/cyan
         Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("So you got away from the wild boars,\n you stop to relax and check your wounds");
         Console.WriteLine("You see bandages laying in the distance or Gold in the other direction :\n 1. Bandage 2. Gold.");
          
         string gold = Console.ReadLine();
         int y = 1 & 2;
         
         Int32.TryParse(gold, out y);
         
         if (y == 1)
         {
             
             Health.GainHealth(); // passes to Scene2 if bandage is selected  increments health
             Start();
             Scene2();
             
         }
     
         else if (y == 2) // passes to Scene3 if Gold is selected and decrements health
         {
            
             Health.LoseHealth();// decrements health
                Start();
                Scene3();
                
         }
         else
         {
             if (y > 2 || y < 0)
             {
                 Console.WriteLine("Invalid Input");
             }
             
         }
             
     }
     public  static void Scene2()
     {
         Console.ForegroundColor = ConsoleColor.DarkMagenta;// changes console to magenta/blue
         Console.BackgroundColor = ConsoleColor.DarkBlue;
         Console.WriteLine("You have survived thus far, you will be rewarded!!!");
        Console.WriteLine("What is your dog's name?");
        Duck = Console.ReadLine();//takes user imput and stores in property Duck
        GainHealth();// increments health
        Start();
        Scene4();
     }
     public static void Scene3()
     {
        Console.WriteLine("You want those riches,get that Money, here's some advice from Warren Buffet....");
        Console.WriteLine("Only buy something that you’d be perfectly happy to hold \nif the market shuts down for ten years.”");
        Console.WriteLine();
        Console.WriteLine("Any thing in the world,what is it...");
        Prize = Console.ReadLine();// takes user input and stores in property Prize
        var d = 1;
        if (d == 1)
        {
            Health.LoseHealth();// decrements health
            Start();
            Scene5();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        

     }
     public static void Scene4()
     {
        Console.WriteLine($"Your dog's name is : {Duck} ");
        Console.WriteLine("Your dog leads you to a make shift shack in the distance.\nIt is cold and dark out here!!");
        Health.GainHealth();//increments health
        Start();
        Scene6();
        

     }

     public static void Scene5()
     {
        Console.WriteLine($"Your {Prize} is weighing you down, you stumble then take a seat next to an old oak tree,");
        Console.WriteLine($"you are feeling weak, you cant eat {Prize}, you pass out");
        Health.LoseHealth();// decrements health
        Start();
        Scene7();
        
     }

     public static void Scene6()
     { 
         Console.ForegroundColor = ConsoleColor.Gray;// changes console to red/cyan
         Console.BackgroundColor = ConsoleColor.DarkRed;
         Health.End();// last readout of health score
         Console.WriteLine("You walk up , pull on the door, it opens....");
        Console.WriteLine($"you and {Duck} walk in, sitting in the chair is {Program.Friend}");
        Console.WriteLine($"{Program.Friend} leads you to safety, you win a cruise and vacation from the ruff life");
        Graphic.Image();//calls image 1
        System.Environment.Exit(0);//exits console app when you hit button

        }

     public static void Scene7()
     {
         Console.ForegroundColor = ConsoleColor.Gray;// changes console to red/cyan
         Console.BackgroundColor = ConsoleColor.DarkRed;
         Health.End();// last readout of health score
         Console.WriteLine($"You awaken from a tap on the shoulder, it's your buddy {Program.Friend}.");
        Console.WriteLine($"He gives you nourishment and helps you carry the gold and {Prize}");
        Console.WriteLine($"you recover and with your share of Gold and {Prize} you bought a BW3 franchise");
        Console.ResetColor();// resets console color scheme
        Graphic2.Image2();// call image 2
        System.Environment.Exit(0);//exits console app when you hit button
        
        
       
        
     }




    }
       




               
    
}
           


         
         
        

        
         
                
         
        

        
        
            




























       

    
    
    







    
   
    
    

    
    
    
    
    

   
    
    
 

   

    
 


    

    
    
    
    
    
    

