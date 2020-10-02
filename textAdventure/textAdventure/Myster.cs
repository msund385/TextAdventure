namespace TextAdventure
{
    using System;
    using System.Collections.Generic;
    using textAdventure;

    /// <summary>
    /// Defines the <see cref="Myster" />.
    /// </summary>
    internal class Myster : Health
    {
        
        
        public static int Myst { get; set; }
        public static string Firm { get; set; }
        public static int Monster { get; set; }
        public static int Weapon { get; set; }
        public static void Mystery()
        {
            Console.ResetColor();//resets console color
            Console.BackgroundColor = ConsoleColor.Yellow; //changes console backround
            Console.ForegroundColor = ConsoleColor.DarkGreen;// and foreground color  yellow/dark green
            var random = new Random();// new variable
            var mystery = new List<string>();//creates new list
            mystery.Add("The slender man");//adds to list
            mystery.Add("Michael Myers");// ||
            mystery.Add("Freddy Kruger");// ||
            mystery.Add("Ghostface");//     <>
            mystery.Add("Hannibal");
            mystery.Add("Leatherface");
            mystery.Add("Jack Torrance");
            mystery.Add("Jigsaw");
            mystery.Add("Pennywise");
            mystery.Add("Norman Bates");
            int Myst = random.Next(mystery.Count);//picks a random item from list// craetes myst variable
          
           

            var weapons = new List<string>();//creates new list
            weapons.Add("Gun");              //adds to list
            weapons.Add("Chainsaw");               // ||
            weapons.Add("Super natural gifts");   //  ||
            mystery.Add("Ghostface");            //   <>
            weapons.Add("Hook");
            weapons.Add("Machete");
            weapons.Add("Explosives");
            weapons.Add("Teeth biting");
            weapons.Add("Fisticuffs");
            weapons.Add("Axe");
            weapons.Add("Knife");
             Weapon = random.Next(weapons.Count);//picks a random item from list//creates variable weapon

            var weap = new List<string>();
            weap.Add("Knife");
            weap.Add("Tire Iron");
            weap.Add("Billy Club");
            weap.Add("Machette");
            weap.Add("Brass Knuckles");
            weap.Add("Katana Blade");
            weap.Add("Grenade");
            Monster = random.Next(weap.Count);
          
                

            int d = 1;//creates variable d
            Console.WriteLine($"Sitting here thinking, Mom use to tell me when you grow older,time moves quicker,but as a young child I threw that thought around in my");
            Console.WriteLine("mind, time moves the same. I couldn't quite grasp it,");
            Console.WriteLine("but now that I'm older it came to light. Life isn't tangible,it's in");
            Console.WriteLine("motion, you live it and grow with the times, and what a time it has been.\nAs I sit here,I have to make choices,and some ");
            Console.WriteLine("choices are tough. Some you don't want to contemplate, but time\nmoves you forward to the road in front of you. I must make choices ");
            Console.WriteLine($"and deal with the consequences, but i'm a survivor.\nI make this choice with confidence. ");
            Console.WriteLine($"Just then {mystery[Myst]} comes at you");
            Console.WriteLine($"swinging a  {weapons[Weapon]}");
            Console.WriteLine($"you grab your {weap[Monster]} and SCREAM!!!!! ");
            Console.WriteLine($"'Hey {mystery[Myst]}, time flies,\nbut what your attempting does not!!!!!' I.........");
            Console.WriteLine($"------------\n1.Attack {mystery[Myst]} with your {weap[Monster]}\n2.Make an escape from {mystery[Myst]} with my vitality attached");
             Firm = Console.ReadLine();
            Int32.TryParse(Firm, out d);
             if (d == 1)
             {
                Console.WriteLine($"You swing your {weapons[Weapon]}");
                Console.WriteLine("You Miss!!!!!!");
                Console.WriteLine($"{mystery[Myst]} hits you with a {weap[Monster]}");
                Console.WriteLine($"just then {Flow1.Duck} comes from behind");
                Console.WriteLine($"and subdues {mystery[Myst]}, you have a scar to show off and");
                Console.WriteLine("remember this by, but your here, alive and here now!!!!");
                Console.WriteLine($" You take {mystery[Myst]}'s weapon!!!");
                Console.WriteLine($"You now have a {weap[Monster]} ");
                Console.WriteLine("You plan, but life has a habit of taking the wheel (-).");
                Console.WriteLine($"Don't let  {mystery[Myst]} take your wheel!!!");
                Health.LoseHealth();
                Health.End();
                Flow1.Scene8();
             }

            if (d == 2)
            {  Console.WriteLine($"You take off swiftly,{Flow1.Duck} is right behind you, you stumble and then regain your step, you continue to keep pace,");
                Console.WriteLine($"{mystery[Myst]} can't keep up, you out pace {mystery[Myst]},you and {Flow1.Duck} slide up against an embankment");
                
                Console.WriteLine($"You have made it through {Flow1.Hero}, Congrats!!!!");
                Console.WriteLine("We plan, but life has a way of taking the wheel(-)");
                Console.WriteLine($"Don't let {mystery[Myst]}  take the wheel from you!!!");
                Health.GainHealth();
                Health.Start();
                Flow1.Scene7();

          

               
            }
            else
            {
                Console.WriteLine("Invalid Input"); //if invalid input is entered
            }
            
               
            
        }
    }
}
