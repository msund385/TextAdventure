﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using textAdventure;

namespace TextAdventure
{
     public class Menu 
    {
         public static string Pick1 { get; set; }

        public static void Menu1()
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("******************  Welcome To The Walk  *****************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("*****************   Press 1: Start Game  *****************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("*****************   Press 2: Exit Game   *****************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("*****************  Press 3:  Credits    ******************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("**********************************************************************");
            int y = 1;
            Pick1 = Console.ReadLine();
            Int32.TryParse(Pick1, out y);
            Console.Clear();


             if (y == 1)
             {
                Flow1.Continue();
             }
             else if (y == 2)
             {
                System.Environment.Exit(0);
             }
             else if (y == 3)
             {

                Credits.Credit1();

            }
             while(y <= 0 || y >= 4)
             {
              
                Console.WriteLine("Invalid Input");
                Graphic1.Image1();
             }
             










        }











     }
}