using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("title1", "author1", 0);
        video1.NewComment("Cauthor1", "comment 1");
        video1.NewComment("Cauthor2", "comment 2");
        video1.NewComment("Cauthor3", "comment 3");
        video1.NewComment("Cauthor4", "comment 4");

        Video video2 = new Video("", "", 0);
        video2.NewComment("", "");
        video2.NewComment("", "");
        video2.NewComment("", "");
        video2.NewComment("", "");

        Video video3 = new Video("", "", 0);
        video3.NewComment("", "");
        video3.NewComment("", "");
        video3.NewComment("", "");
        video3.NewComment("", "");

        Video video4 = new Video("", "", 0);
        video4.NewComment("", "");
        video4.NewComment("", "");
        video4.NewComment("", "");
        video4.NewComment("", "");

    }
}