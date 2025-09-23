using System;

class Program
{
    static void Main(string[] args)
    {
        string referance1 = "Proverbs 3:5";
        string referance2 = "Proverbs 3:5-6";
        string verse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        List<string> verses = new List<string>();
        verses.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        verses.Add("In all thy ways acknowledge him, and he shall direct thy paths.");
        Reference reference = new Reference(referance2, verses);
        Scripture scripture = new Scripture(reference.GetScriptureList());
        Word word = new Word();
        bool exit = false;

        static void DisplayVerse(string reference, string[] scripture)
        {
            Console.WriteLine(reference);
            foreach (string word in scripture)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void DisplayVerses(string reference, List<string[]> scriptures)
        {
            Console.WriteLine(reference);
            foreach (string[] scripture in scriptures)
            {
                foreach (string word in scripture)
                {
                    Console.Write(word);
                    Console.Write(" ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }
        do
        {
            Console.Clear();
            exit = word.GetExit();
            DisplayVerses(reference.GetReference(), scripture.GetWordsListList());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string inpt = Console.ReadLine();
            if (inpt.ToLower() == "quit")
            {
                exit = true;
            }
            else
            {
                scripture.SetWordsListList(word.BlankOutVerses(scripture.GetWordsListList()));
            }
        } while (exit == false);
        
    }
}