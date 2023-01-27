using System;

public class Journal
{
  public string JournalFile = "journal.txt";

  // public void Run()
  // {
  //   CreateJournalFile();

  // }
  // public void CreateJournalFile()
  // {
  //   // This checks to see if the file exists, if it does not, it creates one for the user
  //   if (!System.IO.File.Exists(JournalFile))
  //   {
  //     System.IO.File.CreateText(JournalFile);
  //   }
  // }

  // These two objects above check to see if the file exists, if it does it writes to the file,
  // If it does not it makes a new file.

  public void DisplayJournalContents(Display display, Journal myJournal, promptGenerator prompt)
  {
    string JournalText = System.IO.File.ReadAllText(JournalFile);
    Console.WriteLine("\nJournal Contents:");
    Console.WriteLine(JournalText);
    Console.WriteLine("");
    display.menu(display, myJournal, prompt);
  }

  public void AddEntry(Display display, Journal myJournal, promptGenerator prompt)
  {
    DateTime date = DateTime.Now;
    Console.WriteLine("\nWhat would you like to add to the journal?\n");
    string newEntry = Console.ReadLine();
    System.IO.File.AppendAllText(JournalFile, $"\nEntry {date}:\n> {newEntry}");
    Console.WriteLine("\nThe entry has been added to the journal");
    display.menu(display, myJournal, prompt);
  }

    public void AddEntryWithPrompt(Display display, Journal myJournal, promptGenerator prompt)
  {
    DateTime date = DateTime.Now;
    string newPrompt = prompt.GetRandomPrompt();
    Console.WriteLine(newPrompt);
    Console.WriteLine("\nWhat would you like to add to the journal?\n");
    string newEntry = Console.ReadLine();
    System.IO.File.AppendAllText(JournalFile, $"\nEntry {date}:\n> {newPrompt} {newEntry}");
    Console.WriteLine("\nThe entry has been added to the journal");
    display.menu(display, myJournal, prompt);

  }

  public void ClearJournal(Display display, Journal myJournal, promptGenerator prompt)
  {
    Console.WriteLine("Are you sure you would like to clear the journal?");
    Console.WriteLine("Please type 'clear' to confirm clearing the journal");
    string clear = Console.ReadLine();
    if (clear == "clear")
    {
      System.IO.File.WriteAllText(JournalFile, "");
      Console.WriteLine("\nThe journal has been cleared\n");
      Console.WriteLine(display);
      display.menu(display, myJournal, prompt);
    }
    else
    {
      Console.WriteLine(display);
      display.menu(display, myJournal, prompt);
    }
  }

  public void WaitForKey(Display display, Journal myJournal, promptGenerator prompt)
  {
    Console.WriteLine("Press any key to return to menu\n");
    Console.ReadKey(true);
    display.menu(display, myJournal, prompt);
  }
}

public class Display
{
  public string title;
  public string loadJournal;
  public string addJournal;
  public string addJournalWithPrompt;
  public string clearJournal;
  public string option;
  public void menu(Display display, Journal myJournal, promptGenerator prompt)
  {
    Console.WriteLine(display.title);
    Console.WriteLine(display.loadJournal);
    Console.WriteLine(display.addJournal);
    Console.WriteLine(display.addJournalWithPrompt);
    Console.WriteLine(display.clearJournal);
    Console.Write(display.option);
    int keyForMenu = int.Parse(Console.ReadLine());
    if (keyForMenu == 1)
    {
      myJournal.DisplayJournalContents(display, myJournal, prompt);
    }
    else if (keyForMenu == 2)
    {
      myJournal.AddEntry(display, myJournal, prompt);
    }
    else if (keyForMenu == 3)
    {
      myJournal.AddEntryWithPrompt(display, myJournal, prompt);
    }
    else if (keyForMenu == 4)
    {
      myJournal.ClearJournal(display, myJournal,prompt);
    }
  }
}

public class promptGenerator
{
  public List<string> _prompts;

  public string GetRandomPrompt()
  {
    return "What color do you feel like today and why?";
  }
}