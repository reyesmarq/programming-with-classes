class Program
{
    static void Main(string[] args)
    {
        Video video1 = new("CodelyTv", "CodelyTv", 300);
        video1.AddComment(new Comment("Oscar", "How can I download this video?"));
        video1.AddComment(new Comment("Josue", "How can I implement this in my project?"));
        video1.AddComment(
            new Comment("David", "I'm lost, can you explain it again with microservices?")
        );

        Video video2 = new("Midudev", "Midudev", 2000);
        video2.AddComment(new Comment("Marisol", "Awesome Content!"));
        video2.AddComment(new Comment("Mario", "Great, but I was expecting more"));
        video2.AddComment(new Comment("Carlos", "Too long"));

        Video video3 = new("Platzy", "Platzy", 600);
        video3.AddComment(new Comment("Karla", "Keep it up!"));
        video3.AddComment(new Comment("Miguel", "I got lost in the middle"));
        video3.AddComment(new Comment("Samuel", "Nee to start over"));

        List<Video> videos = [video1, video2, video3];

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length}");
            Console.WriteLine($"Comments count: {video.GetCommentsCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Name: {comment.Name}");
                Console.WriteLine($"Comment: {comment.Text}");
            }
        }
    }
}
