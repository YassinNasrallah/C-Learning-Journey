
using System;

  class Player
  {
    static void Main(string[] args)
    {
        // Stores a single character (only one letter, number, or symbol)
         char firstCharacter = '$';

        // Stores a sequence of characters (text)
         string characterName = "Yassin";

        // Stores a whole number (integer)
         int characterAge = 20;
         
        // Stores decimal numbers with high precision (used for money and prices)
         decimal PlaystationPrix = 549.99m;
         decimal tlouPrix = 69.99m;
         decimal Total = PlaystationPrix + tlouPrix;
        
        // Stores decimal numbers (used for speed, position, and physics)
         float Speed = 100.8f;
        
        Console.WriteLine("HII im " + characterName + " im "+ characterAge + " im frontend developer and game progrmmer ");
        Console.WriteLine("i bouth console and one game for " + Total + firstCharacter );
        Console.ReadLine();
    }
  }

