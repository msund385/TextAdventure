using System;
using System.Collections.Generic;
using System.Text;
using textAdventure;

namespace TextAdventure
{
    class Help : Flow1
    {
        
        public string Pick2 { get; set; }// property creates Pick2
       
        public static void Savior()
        {
            var random1 = new Random();// creates new variable 
                
            var random = new Random();// creates new variable 
            var characters = new List<string>();// creates list character
            characters.Add("Frozone"); //Adds characters to list
            characters.Add("Baloo");
            characters.Add("Maleficent");
            characters.Add("Mr.Fox");
            characters.Add("Lilo");
            characters.Add("Snow White");
            characters.Add("Scar");
            characters.Add("Jack Skellington");
            characters.Add("Winnie the Pooh");
            characters.Add("Boo");
            characters.Add("Kronk");
            characters.Add("Toothless");
            characters.Add("Roger Rabbit");
            characters.Add("Mulan");
            characters.Add("Ginger");
            characters.Add("Dug");
            characters.Add("Jasmine");
            characters.Add("Remy The Rat");
            characters.Add("Chihiro");
            characters.Add("Donkey");
            characters.Add("Wall-E");
            characters.Add("Cruella De Vil");
            characters.Add("Totoro");
            characters.Add("Goofy");
            characters.Add("Woody");
            characters.Add("The Iron Giant");
            characters.Add("Genie");
            characters.Add("Dory");
            characters.Add("Mickey Mouse");
            characters.Add("Dory");
            int index = random.Next(characters.Count);//picks a random character from list
            Console.WriteLine("Your hero has arrived:");
            Console.WriteLine(characters[index]);//prints to console

            var items = new List<string>();// creates list items
            items.Add("Hand crank can opener");//Adds items to list
            items.Add("Canned Meat");
            items.Add("Fruit bars");
            items.Add("Granola");
            items.Add("Peanut butter");
            items.Add("Dried Fruit");
            items.Add("Battery powered radio");
            items.Add("Batteries");
            items.Add("Flashlight");
            items.Add("First Aid kit");
            items.Add("Antibiotic cleansing agent");
            items.Add("Scissors");
            items.Add("Wrench");
            items.Add("American Express Black card");
            items.Add("Fire Extinguisher");
            items.Add("Flint & Steel");
            items.Add("Water");
            items.Add("Hatchet");
            items.Add("Axe");
            items.Add("Lucky Rabbit's Foot");
            items.Add("Bag of food items");
            items.Add("A Winning lottery ticket");
            items.Add("Picture of your soulmate");
            items.Add("Picture of a family member");
            items.Add("Your grandma's luckey key chain");
            items.Add("Gun");
            items.Add("A blood stain shirt");
            items.Add("A laptop with no wifi");
            items.Add("Your notebook full of million $ ideas");
            items.Add("Mp3 player with your favorite song");
            items.Add("A cellphone with 25% battery");
            items.Add("A bag of batterys");
            items.Add("Your grandpa's knife from WWII");
            items.Add("A bottle of water");
            items.Add("Your High School yearbook");
            items.Add("A Soccer ball & marker");
            items.Add("A plane ticket to Belize");
            items.Add("Your Partner in Crime");
            items.Add("Your 3rd birthday card");
            items.Add("Keys to a car");
            items.Add("A car battery");
            items.Add("A pen & paper");
            items.Add("Your utility tool");
            int item = random1.Next(items.Count);//picks a random item from list
            Console.WriteLine("Your hero has brought you a gift:");
            Console.WriteLine( items[item]);//prints to console


































        }


    }

}

                                                                             

            
        
        
        


    

