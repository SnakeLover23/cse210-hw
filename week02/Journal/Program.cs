using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal.");
        Entry entrys = new Entry();
        LoadSave file = new LoadSave();
        bool exit = false;
        bool saved = true;
        do
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Write entry");
            Console.WriteLine("2) Display journal");
            Console.WriteLine("3) Save journal");
            Console.WriteLine("4) Load journal");
            Console.WriteLine("5) Exit");
            Console.Write("Type in a number to select an option: ");
            string inpt = Console.ReadLine();
            Console.WriteLine("");

            if (inpt == "1")
            {
                entrys.NewEntry();
                saved = false;
            }
            else if (inpt == "2")
            {
                entrys.Display();
            }
            else if (inpt == "3")
            {
                Console.Write("What file path would you like to save to: ");
                string filename = Console.ReadLine();
                file.Save(filename, entrys._entrys);
                Console.WriteLine($"Your entrys have been saved to {filename}");
                Console.Write("Press [Enter] to continue.");
                string stop = Console.ReadLine();
                Console.WriteLine("");
                saved = true;
            }
            else if (inpt == "4")
            {
                Console.Write("What file path would you like to load from: ");
                string filename = Console.ReadLine();
                entrys._entrys = file.Load(filename);
                Console.WriteLine($"Your entrys have been loaded from {filename}");
                Console.Write("Press [Enter] to continue.");
                string stop = Console.ReadLine();
                Console.WriteLine("");
            }
            else if (inpt == "5")
            {
                if (saved == false)
                {
                    Console.WriteLine("Are you sure you want to exit, all unsave entrys will be lost.");
                    Console.Write("Type [y] to confirm, type anything else to return to menue: ");
                    inpt = Console.ReadLine();
                    Console.WriteLine("");
                    if (inpt == "y")
                    {
                        exit = true;
                    }
                }
                else
                {
                    exit = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Press [Enter] to continue.");
                string stop = Console.ReadLine();
                Console.WriteLine("");
            }
        } while (exit == false);
        Console.WriteLine("Goodbuy");
    }
}