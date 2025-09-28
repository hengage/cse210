class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Alice", 600);
        video1.AddComment(new Comment("Brady", "Great video!"));
        video1.AddComment(new Comment("Thierry", "Very helpful."));
        video1.AddComment(new Comment("Martha", "Thanks for sharing!"));

        Video video2 = new Video("OOP Basics", "David", 900);
        video2.AddComment(new Comment("Igor", "Clear explanation."));
        video2.AddComment(new Comment("Christian", "This helped me a lot."));
        video2.AddComment(new Comment("Grace", "Awesome tutorial!"));

        Video video3 = new Video("JavaScript Fundamentals", "Hannah", 750);
        video3.AddComment(new Comment("Kachi", "Loved it!"));
        video3.AddComment(new Comment("Ify", "Very informative."));
        video3.AddComment(new Comment("Kathy", "Well done!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display info for each video
        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetVideoInfo());
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine(c.DisplayComment());
            }
            Console.WriteLine();
        }
    }
}
