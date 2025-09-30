using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to drink water.", "The_How_To_Guy", 1203);
        video1.NewComment("Thirsty1234", "Thx i relly needd this");
        video1.NewComment("The_Real_How_To_Guy", "Thats not me!!!");
        video1.NewComment("xX_EpicGamer_Xx", "Cool video but why was it 20 minutes");
        video1.NewComment("CatMan88", "Instructions unclear, accidently restarted the USSR");

        Video video2 = new Video("Why Hollow Knight Silksong is the greatest game ever.", "xX_EpicGamer_Xx", 913);
        video2.NewComment("CatMan88", "I still can't believe this game is real");
        video2.NewComment("Hater69", "Come on EpicGamer, everyone knows that Concord was the real goat");
        video2.NewComment("Zote_The_Mighty", "It looks like a good game but its missing something important");
        video2.NewComment("Generic Fan", "Wooo Silksong!");

        Video video3 = new Video("Games Journalist was right about everything.", "Hater69", 7225);
        video3.NewComment("Generic Fan", "Bruuhh");
        video3.NewComment("xX_EpicGamer_Xx", "I dare you to watch his playthrough of cuphead");
        video3.NewComment("CatMan88", "Krill your shelf!");
        video3.NewComment("Jet2Holliday", "Nothing beats a Jet2 hollidy");

        Video video4 = new Video("Cats dancing to Horst-Wessel-Lied 10 hour loop", "CatMan88", 36024);
        video4.NewComment("xX_EpicGamer_Xx", "Why would you make this");
        video4.NewComment("Hater69", "I couldn't understand a word of the song, mabye you need to get better singers");
        video4.NewComment("DogMan77", "Why are you the way that you are");
        video4.NewComment("Sebastion_Solace", "Why was this on p.A.I.nters watch history");

        video1.Display();
        Console.WriteLine("");
        Console.Write("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        video2.Display();
        Console.WriteLine("");
        Console.Write("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        video3.Display();
        Console.WriteLine("");
        Console.Write("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        video4.Display();
        Console.WriteLine("");
        Console.Write("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
}