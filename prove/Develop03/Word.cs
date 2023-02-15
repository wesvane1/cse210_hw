using System;

public class Word
{
  // List<string> Words = new List<string>();
  private string _words;
  // private string _words;
  public Word(string words)
  {
    _words = words;

    // This returns the number of charactors in the string.
    // Console.WriteLine(words.Length);


    // for (int i=0; i < words.Length-1; i++){
    //   string[] splitter = words.Split(" ");
    //   Words.Add(splitter[i]);
    // }
    // Console.WriteLine(Words);
    // Random randomNum = new Random();
    // int randomNumber = randomNum.Next(0,46);
    // string randomWord = Words[randomNumber];
    // Console.WriteLine(Words[randomNumber]);


  }
  // public List<string> wordList(string words){
  //   _words = words;
  //   for (int i=0; i < words.Length; i++){
  //     string[] splitter = words.Split(" ");
  //     Words.Add(splitter[i]);
  //   }
  //   return Words;
  // }

  public string getWords(){
    return _words;
  }
  public string randomWord(string words){
    _words = words;
    List<string> Words = !string.IsNullOrEmpty(words) ? words.Split(' ').ToList() : new List<string>();
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
  // public string randomWord(string words){
  //   _words = words;
  //   Random test = new Random();
  //   int testRandom = test.Next(words.Count);
  //   string testWord = words[testRandom];
  //   return testWord;
  // }
}