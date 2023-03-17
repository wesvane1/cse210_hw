using System;

class Program
{


  static void Main(string[] args)
    {
      Console.WriteLine("Hello Develop03 World!");

      // display the reference
      Reference ref1 = new Reference("Moses", 1, 38, 39);
      Word words = new Word("And as one earth shall pass away, and the heavens thereof even so shall another come; and there is no end to my works, neither to my words. For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
      Scripture scrip1 = new Scripture(ref1, words);

      string scrip = "this is a test";
      while(true)
      {
        Console.Write("Press any key to enter, or type quit to end the program:\n");
        string entry = Console.ReadLine();
        if(entry == "")
        {
          Console.Clear();
          Console.WriteLine(scrip);
          Console.WriteLine($"{ref1.getRef1()} {words.randomWord(words.getWords())}");
        }
        else
        {
          Console.Clear();
          Console.WriteLine("This is the end of the line buck-o");
          while(false);
        }
      }
    }
}