using System;

class Program {
  public static void Main(string[] args)
    {
        int age;

        Console.WriteLine("Determines what type of movie you can watch.");
        Console.WriteLine("");

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= 17) {
          Console.WriteLine("You can watch an R rated movie alone!");
        }
        else if (age >= 13) {
          Console.WriteLine("You can watch a PG-13 rated movie alone! ");
        }
        else if (age >= 5) {
          Console.WriteLine("You can watch a PG rated movie alone! ");
        }
        else {
          Console.WriteLine("You're too young to do most things! ");
        }

        Console.WriteLine("\nDone.");
    }
}