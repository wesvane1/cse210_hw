using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Comment c1 = new Comment();
        c1._commentName="Jake";
        c1._commentText="Love this";
        Comment c2 = new Comment();
        c2._commentName="Nic";
        c2._commentText="Great Content";
        Comment c3 = new Comment();
        c3._commentName="Paloma";
        c3._commentText="I don't like your opinion";
        Video v1 = new Video();
        v1._videoTitle = "Minecraft Create";
        v1._videoAuthor = "Sky";
        v1._comment1.Add(c1);
        v1._comment1.Add(c2);
        v1._comment1.Add(c3);
        v1.Display();

        Comment c4 = new Comment();
        c4._commentName="Danee";
        c4._commentText="Nice numbers";
        Comment c5 = new Comment();
        c5._commentName="Oliver";
        c5._commentText="I can count too";
        Comment c6 = new Comment();
        c6._commentName="Joan";
        c6._commentText="googoo gaga";
        Video v2 = new Video();
        v2._videoTitle = "Fly me to the moon cover";
        v2._videoAuthor = "Post";
        v2._comment2.Add(c4);
        v2._comment2.Add(c5);
        v2._comment2.Add(c6);
        v2.Display();

        Comment c7 = new Comment();
        c7._commentName="Savanna";
        c7._commentText="I use the same algorithm!";
        Comment c8 = new Comment();
        c8._commentName="Nic";
        c8._commentText="Great Content";
        Comment c9 = new Comment();
        c9._commentName="Paloma";
        c9._commentText="Glad there are no parodies on this puzzle";
        Video v3 = new Video();
        v3._videoTitle = "Solving a 3x3 Rubik's cube";
        v3._videoAuthor = "Wes";
        v3._comment3.Add(c7);
        v3._comment3.Add(c8);
        v3._comment3.Add(c9);
        v3.Display();
        
    }
}