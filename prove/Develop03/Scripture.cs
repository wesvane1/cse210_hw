public class Scripture
{

  private Reference _ref1;
  private Word _allWord;

    public Scripture(Reference reference, Word words){
      _ref1 = reference;
      _allWord = words;
      Console.WriteLine($"{reference.getRef1()} {words.getWords()}");
    }
}