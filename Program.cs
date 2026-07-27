
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
         int validAge = 18;
        // Stores decimal numbers with high precision (used for money and prices)
         decimal PlaystationPrix = 549.99m;
         decimal tlouPrix = 69.99m;
         decimal Total = PlaystationPrix + tlouPrix;
        
        // Stores decimal numbers (used for speed, position, and physics)
         float Speed = 100.8f;
         bool valid;
         //sheck if user information is valid 
         
           Console.Write("Enter Your Age:");
           int characterAge = Convert.ToInt32((Console.ReadLine()));
           Console.Write("Enter Your email:");
           string userEmail = Console.ReadLine();
         if(characterAge >= validAge && userEmail.Contains("@gmail.com"))
         {
          valid = true;
          Console.WriteLine("succes");
         } 
         else
         {
           valid = false;
           Console.WriteLine("invalid");
         }

          //deal with array 
        string [] frindsList = new string[3];
        frindsList[0] = "abdrahman";
        frindsList[1] = "yassin";
        frindsList[2] = "mohamed";
        if(frindsList.Contains("abdrahman")){
           Console.WriteLine("Welcome");
        } else{
          Console.WriteLine("You are not welcome");
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

