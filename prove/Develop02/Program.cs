using System;

class Program
{

    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Display display = new Display();
        promptGenerator prompt = new promptGenerator();
        display.title = "Welcome to the BEST journal on the market";
        display.loadJournal = "1: Load Journal";
        display.addJournal ="2: Add Journal Entry";
        display.addJournalWithPrompt = "3: Add Journal Entry with Prompt";
        display.clearJournal = "4: Clear Journal";
        display.option="Pleas select an option\n";
        display.menu(display, myJournal,prompt);
        // myJournal.run(myJournal, display)
        Console.WriteLine(myJournal.JournalFile);
        // The above line will write the file name
    }
}