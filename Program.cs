//we used void when function return nothing
using System;

  class Player
  {
    static void Main(string[] args)
    {
        // Stores a sequence of characters (text)
         string characterName = "Yassin";
        // Stores a whole number (integer)      
          Uservalidate();
          Friendslist();
          float total = Sum(3, 6);
          Console.WriteLine(total);
          Console.WriteLine($"result of sum two number is : {sumtwonumber()}");
          Console.ReadLine();
    }


    //uservalidation
    static void Uservalidate(){
          bool valid;
          int validAge = 18;    
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

    }
      //sum two numbers
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
      
      //frinds list
      static void Friendslist(){
        string [] frindsList = new string[3];
        frindsList[0] = "abdrahman";
        frindsList[1] = "yassin";
        frindsList[2] = "mohamed";
        if(frindsList.Contains("abdrahman")){
           Console.WriteLine("Welcome");
        } else{
          Console.WriteLine("You are not welcome");
        }
      }


       static float Sum(float a, float b){
          return a + b;
        }

  }

