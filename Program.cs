using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("The magic sphinx appears...");
    Console.WriteLine("You seem to have woken it from a nap.");
    Console.WriteLine("For that it must eat you...unless you correctly answer its' riddle :)");
    Console.WriteLine("Do you accept? [Y for yes | 'enter' for no]");

    string userInput = Console.ReadLine();
    if(userInput == "y" || userInput == "Y")
    {
      // Riddle #1------------------------------------------------------------------------------------------------
      Console.WriteLine("What has rivers and mountains, but no water or rocks?");
      string answerString = Console.ReadLine();
      if(answerString == "map" || answerString == "Map" || answerString == "a map" || answerString == "A Map")
      {
        Console.WriteLine("You are correct!");
      }
      else
      {
        Console.WriteLine("You are wrong, it eats you!");
      }

      // Riddle #2------------------------------------------------------------------------------------------------
      Console.WriteLine("If you feed it, it lives; If you water it, it dies. What is it?");
      string answerString2 = Console.ReadLine();
      if(answerString2 == "fire" || answerString2 == "Fire" || answerString2 == "a fire" || answerString2 == "A Fire")
      {
        Console.WriteLine("You are correct!");
      }
      else{
        Console.WriteLine("You are wrong, it eats you!");
      }

        // Riddle #3------------------------------------------------------------------------------------------------
      Console.WriteLine(" What begins and ends with an 'e' but only contains one letter?");
      string answerString3 = Console.ReadLine();
      if(answerString3 == "envelope" || answerString3 == "Envelope" || answerString3 == "an envelope" || answerString3 == "An Envelope")
      {
        Console.WriteLine("You are correct!");
      }
      else{
        Console.WriteLine("You are wrong, it eats you!");
      }

        // Riddle #4------------------------------------------------------------------------------------------------
      Console.WriteLine("I have keys, but no locks. I have space, but no room. You can enter, but you can’t go outside. What am I?");
      string answerString4 = Console.ReadLine();
      if(answerString4 == "keyboard" || answerString4 == "Keyboard" || answerString4 == "a keyboard" || answerString4 == "A Keyboard")
      {
        Console.WriteLine("You are correct!");
      }
      else{
        Console.WriteLine("You are wrong, it eats you!");
      }
    }
    else
    {
      Console.WriteLine("It eats you anyway");
    }
  }
}