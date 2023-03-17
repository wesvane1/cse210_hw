using System;

public class Word
{
  // List<string> Words = new List<string>();
  private string _words;
  List<string> Words = new List<string>();

  // private string _words;
  public Word(string words)
  {
    _words = words;
    Words = !string.IsNullOrEmpty(words) ? words.Split(' ').ToList() : new List<string>();
  }
  public string getWords(){
    return _words;
  }
  public string randomWord(string words){
    _words = words;
    Random test = new Random();
    int testRand = test.Next(Words.Count);
    string testWord = Words[testRand];
    
    string dashed = "";
    for (int charNum = 0; charNum < testWord.Length; charNum++)
      {
        string dash = ("_");
        dashed += dash;
        Words[testRand] = dashed;
      } 
    Console.WriteLine(dashed);
    // The line below prints the new string of words but with the random word canceled out.
    Console.WriteLine("{0}", string.Join(" ", Words));
    return ($"{Words}");
  }
}