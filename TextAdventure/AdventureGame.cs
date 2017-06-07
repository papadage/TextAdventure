// Author: George Papadakis
// Date Created: 2017-05-26
// This work is a derivative of
// "C# Adventure Game" by http://programmingisfun.com, 
// used under CC BY.
// https://creativecommons.org/licenses/by/4.0/

using System;

namespace TextAdventure // Namespace based on the program to arganize included types
{
   class AdventureGame // Class to contain custom types, variables and events
   {
      static void Main() // Main method groups statements to carry out a task
      {
         // Variable declarations at head of method, by convention
         string CharacterName = "John Doe"; // declare a string variable and initialize it with a specific value
         string Location = "Starting Area";
         string Companion = "parrot";

         Console.WriteLine("Gork!!!"); // Writes a text literal to the console and goes to next line
         Console.WriteLine("A danger behind every rock, and an adventure at every fork!");
         Console.WriteLine(); // Blank line
         Console.WriteLine("Please provide a character name and press Enter:"); // Prompt to user for name
         CharacterName = Console.ReadLine(); // Take input from console and pass to string variable
         Console.WriteLine();
         Console.WriteLine("Great! Your chaarcter is now named " + CharacterName +"!"); // Concatenation with string literal and variable
         // Console.Writeline($"Great! Your chaarcter is now named {CharacterName}!"); // Alternative using string interpolation

         Console.Read(); // Waits for input at the console
      }
   }

   class Game
   {

   }

   class Item
   {

   }
}
/*
 * 2017-05-26: Simplified code by removing unnecessary namespaces and defualt method arguments
 */