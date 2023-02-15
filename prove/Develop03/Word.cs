using System;

public class Word
{
  // List<string> Words = new List<string>();
  private string _words;
  // private string _words;
  public Word(string words)
  {
    _words = words;
    // Random randomNum = new Random();
    // int randomNumber = randomNum.Next(Words.Count);
    // string randomWord = allWordsList[randomNumber];
    // Console.WriteLine(allWordsList[randomNumber]);

    // string dashed = "";
    // for (int charNum = 0; charNum < randomWord.Length; charNum++) 
    //   {
    //     string dash = ("_");
    //     dashed += dash;
    //     allWordsList[randomNumber] = dashed;
    //   } 
    // Console.WriteLine(dashed);
    // // The line below prints the new string of words but with the random word canceled out.
    // Console.WriteLine("{0}", string.Join(" ", allWordsList));
  }

  public string getWords(){
    return _words;
  }
}