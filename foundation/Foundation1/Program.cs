using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        List<Video> videoList = new List<Video>();

        Video video1 = new Video();
        video1._author = "Jessy Vans";
        video1._title = "Vans on my Feet";
        video1._length = "300";
        Comments v1Comment1 = new Comments();
        v1Comment1._name = "Jake VanDyke";
        v1Comment1._comment = "Hecka of a flick bud";
        Comments v1Comment2 = new Comments();
        v1Comment2._name = "Will Pham";
        v1Comment2._comment = "Me like alot";
        Comments v1Comment3 = new Comments();
        v1Comment3._name = "Nate Rancho";
        v1Comment3._comment = "This was amazing. Keep them coming!"; 

        Video video2 = new Video();
        video2._author = "Tony Tido";
        video2._title = "Rolling in my Cadillac";
        video2._length = "100";
        Comments v2Comment1 = new Comments();
        v2Comment1._name = "Mike Buckle";
        v2Comment1._comment = "A little blurry and can't hear you.";
        Comments v2Comment2 = new Comments();
        v2Comment2._name = "Ospree wilder";
        v2Comment2._comment = "Had a car just like this when I was young.";
        Comments v2Comment3 = new Comments();
        v2Comment3._name = "Jose conso";
        v2Comment3._comment = "Man, this brings back memories";

        Video video3 = new Video();
        video3._author = "Tulsa vicks";
        video3._title = "Heavy Rain";
        video3._length = "3000";
        Comments v3Comment1 = new Comments();
        v3Comment1._name = "Troy McMuff";
        v3Comment1._comment = "Really needed this, thank you.";
        Comments v3Comment2 = new Comments();
        v3Comment2._name = "Haka Mafu";
        v3Comment2._comment = "Thanks";
        Comments v3Comment3 = new Comments();
        v3Comment3._name = "Chino Windsor";
        v3Comment3._comment = "Now I can finally get some sleep.";

        video1._commentList.Add(v1Comment1);
        video1._commentList.Add(v1Comment2);
        video1._commentList.Add(v1Comment3);

        video2._commentList.Add(v2Comment1);
        video2._commentList.Add(v2Comment2);
        video2._commentList.Add(v2Comment3);

        video3._commentList.Add(v3Comment1);
        video3._commentList.Add(v3Comment2);
        video3._commentList.Add(v3Comment3);

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            video.DisplayVideo();
        }

    }
}