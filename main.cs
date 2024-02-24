using System;

class Program {
  public static void Main (string[] args) {


    while(true){
      Console.WriteLine("Enter a number: ");
      string input = Console.ReadLine();
      if(input == "0"){
        Console.WriteLine("Closing program...");
        break;
      }
      if (int.TryParse(input, out int num) && num > 0)
      for(int i = 1; i <= num; i++){
        for(int j = 1; j <= num - i ; j++){
          Console.Write(" ");
        }
        for (int l = 1; l <= 2*i-1; l++){
          Console.Write("*");
        }
        Console.WriteLine();
        
      }
      else{
        Console.WriteLine("Invalid value");
      }
    }



  }
  }
