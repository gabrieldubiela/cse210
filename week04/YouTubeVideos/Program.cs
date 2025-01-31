using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("10 Mind-Blowing Space Facts", "Cosmic Explorers", 492);
        Video video2 = new Video("5 Easy Vegan Recipes", "Green Bites Kitchen", 765);
        Video video3 = new Video("How to Start a YouTube Channel", "Creator’s Hub", 930);

        video1.AddComment(new Comment("Sarah T.", "Wow, I had no idea about the diamond planet!"));
        video1.AddComment(new Comment("Mike L.", "Great video, but I wish it went more in-depth about black holes."));
        video1.AddComment(new Comment("Priya R.", "The visuals were stunning!"));

        video2.AddComment(new Comment("Emily S.", "Tried the avocado pasta—so delicious and easy to make!"));
        video2.AddComment(new Comment("Jake P.", "I’m not vegan, but these recipes look too good to pass up."));
        video2.AddComment(new Comment("Lila M.", "Love how simple and budget-friendly these are."));

        video3.AddComment(new Comment("Rita K.", "This was so motivating! Already working on my first video."));
        video3.AddComment(new Comment("Tom H.", "Solid advice, especially about consistency and niche selection."));
        video3.AddComment(new Comment("Nina W.", "I wish there were more tips about editing software."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}