using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System;
using TextAdventure;

namespace textAdventure
{



    internal class Flow1 

    {
        public static string Pick { get; set; } //Property /Pick
        public static string Friend { get; set; }//property / Friend
        public static string Duck { get; set; } //property creates Duck
        public static string Prize { get; set; } //property creates Prize
        public static string Hero { get; set; }

        public static void Continue()
        {
            Console.ForegroundColor = ConsoleColor.Red;// changes console to red/cyan
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hi, welcome to your text adventure,choose your fate");
            Health.Start();
            Console.WriteLine("What is the name of our courageous hero?");
            Hero = Console.ReadLine(); //stores user input
            Console.WriteLine("What is the name of your brave friend   ");
            Friend = Console.ReadLine(); //stores user input
            Console.WriteLine("What is your dazzling magic?            ");
            string magic = Console.ReadLine(); //stores user input
            Console.Clear();
            Console.WriteLine($"Welcome to the land of Cheyenia, where {Flow1.Hero} lives,breathes and ");
            Console.WriteLine($"survives with their pal {Flow1.Friend}.You must use your power of {magic}");
            Console.WriteLine("to save the citizens from destruction. May the swartz be with you!!!      ");
            Console.WriteLine("*****************  Press Enter To Continue   ************************");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Do you go right or left,\nEnter: 1.right or 2.left!!!!                    ");
            Pick = Console.ReadLine();//assigns user input to a variable

            int x = 0;
            Int32.TryParse(Pick, out x);//changes string to int

            if (x == 1)//takes answer 1 or 2 and supplies corresponding answer
            {
                Console.WriteLine("Bad Choice!!You find yourself in the woods,\nyou ran into a pack of wild boars!! You got bitten!!!                ");
                Health.LoseHealth();
                Scene1();
            }
            else if (x == 2)
            {
                Console.WriteLine("Good choice!! You hit a clearing and found a water source.\nYou get some relaxation time and ponder your next move");
                Health.GainHealth();
                Scene2();
            }


        }
        //Scene1--Scene3-Scene5-Scene7
        //Scene1--Scene2--Scene4--Scene6
        public static void Scene1() //2nd set of questions
        {
            Console.ForegroundColor = ConsoleColor.Yellow;// changes console to red/cyan
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("So you got away from the wild boars,\n you stop to relax and check your wounds             ");
            Console.WriteLine("You see bandages laying in the distance or Gold in the other direction :\n1.Bandage 2.Gold.");

            string gold = Console.ReadLine();
            int y = 1 & 2;

             Int32.TryParse(gold, out y);

            if (y == 1)
            {
                Health.GainHealth(); // passes to Scene2 if bandage is selected  increments health
                Health.Start();
                Scene2();
                
            }
            else if (y == 2) // passes to Scene3 if Gold is selected and decrements health
            {
                Health.LoseHealth();// decrements health
                Health.Start();
                Console.WriteLine("You have made it, baby steps!!\nGet it together");
                Console.WriteLine("What is your dog's name?                       ");
                Duck = Console.ReadLine();//takes user imput and stores in property Duck
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
        public static void Scene2()
        {
            Console.ForegroundColor = ConsoleColor.White;// changes console to magenta/blue
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("You have survived thus far, you will be rewarded!!\nGreat Job Hero!!");
            Console.WriteLine("What is your dog's name?                        ");
            Duck = Console.ReadLine();//takes user imput and stores in property Duck
            Health.GainHealth();// increments health
            Health.Start();
            Scene4();
            
        }
        public static void Scene3()
        {
            Console.WriteLine("You want those riches,get that Money, here's some advice from Warren Buffet.....");
            Console.WriteLine("Only buy something that you’d be perfectly happy ");
            Console.WriteLine("to hold if the market shuts down for ten years.");
            Console.WriteLine($"Your Dog {Flow1.Duck} barks                                         ");
            Console.WriteLine("Any thing in the world,what is it you Want??????.....................");
            Prize = Console.ReadLine();// takes user input and stores in property Prize
            Health.End();
            Scene5();
            
           


        }

        public static void Scene4()
        {
            Console.WriteLine($"Your dog's name is :{Flow1.Duck}                        ");
            Console.WriteLine("Your dog leads you to a make shift shack in the distance.");
            Console.WriteLine("It is cold and dark out here!!");
            Health.GainHealth();//increments health
            Health.End();
            Help.Savior();//calls savior method in Help class
           

        }



        public static void Scene5()
        {
            Console.WriteLine($"Your {Flow1.Prize} is weighing you down, you stumble ");
            Console.WriteLine("then take a seat next to an old oak tree,");
            Console.WriteLine($"you are feeling weak, you cant eat {Flow1.Prize}, you pass out");
            Health.LoseHealth();// decrements health
            Health.End();
            Help.Savior();//calls method Savior in Help class

        }

                   



         public static void Scene6()
         {
            
            Console.ForegroundColor = ConsoleColor.Gray;// changes console to red/cyan
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You walk up , pull on the door, it opens....");
            Console.WriteLine($"you and {Flow1.Duck} walk in, sitting in the chair is {Flow1.Friend}                ");
            Console.WriteLine($"{Flow1.Friend} leads you to safety, you win a cruise and vacation from the ruff life");
            Health.End();// Tracks health
            Graphic.Image();//calls image 1
            System.Environment.Exit(0);//exits console app when you hit button
         }



        public static void Scene7()
        {
            
            Console.ForegroundColor = ConsoleColor.Gray;// changes console to red/cyan
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"You awaken from a tap on the shoulder, it's your buddy {Flow1.Friend}.              ");
            Console.WriteLine($"He gives you nourishment and helps you carry the gold and {Flow1.Prize}             ");
            Console.WriteLine($"you recover and with your share of Gold and {Flow1.Prize} you bought a BW3 franchise");
            Health.End();// last readout of health score
            Console.ResetColor();// resets console color scheme
            Graphic2.Image2();// call image 2
            System.Environment.Exit(0);//exits console app when you hit button
        }


    }

}



    
       




               
    

           


         
         
        

        
         
                
         
        

        
        
            




























       

    
    
    







    
   
    
    

    
    
    
    
    

   
    
    
 

   

    
 


    

    
    
    
    
    
    

