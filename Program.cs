
using System;

  class Player
  {
    static void Main(string[] args)
    {
        // Stores a single character (only one letter, number, or symbol)
         char firstCharacter = '$';

        // Stores a sequence of characters (text)
         string characterName = "Yassin";
         string email = "yassinnassrallah@gmail.com";
        // Stores a whole number (integer)
         int characterAge = 22;
         int validAge = 18;
        // Stores decimal numbers with high precision (used for money and prices)
         decimal PlaystationPrix = 549.99m;
         decimal tlouPrix = 69.99m;
         decimal Total = PlaystationPrix + tlouPrix;
        
        // Stores decimal numbers (used for speed, position, and physics)
         float Speed = 100.8f;
         bool valid = false;

         //sheck if user information is valid 
         if(characterAge >= validAge && email.Contains("@gmail.com"))
         {
          valid = true;
          Console.WriteLine("succes");
         } 
         else
         {
           valid = false;
           Console.WriteLine("invalid");
         }


         

         static int sumtwonumber(){
           int target = 6;
           int[] nums = [1,2,3,4,5,6];
           int total =0;

           for(int i = 0 ; i<nums.Length ; i++)
           {
          
          for(int j = i+1 ;j<nums.Length;j++)
            {
            total = nums[i] + nums[j];

              if(total == target){
                return total;
                }
            }
            
          }
          return -1;
          }
        
        Console.WriteLine(sumtwonumber());
        //Console.WriteLine("HII im " + characterName + " im "+ characterAge + " im frontend developer and game progrmmer ");
        //Console.WriteLine("i bouth console and one game for " + Total + firstCharacter );
        Console.ReadLine();
    }
  }

