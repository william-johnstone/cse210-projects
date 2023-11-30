class Program
{
    static void Main()
    {
        // Creating videos and adding comments
        List<Video> videos = new List<Video>
        {
            new Video("Making a video", "James Cooper", 120),
            new Video("Editing a video", "Charles Lewis", 180),
            new Video("Uploading a video", "Jim Butcher", 150),
            new Video("Deleting a video", "Will Wight", 200),
        };

        videos[0].AddComment("Bob Smith", "Great video!");
        videos[0].AddComment("Gary Springer", "Interesting content.");

        videos[1].AddComment("Adam McDonald", "Nice work!");
        videos[1].AddComment("Bruce Low", "I learned a lot.");

        videos[2].AddComment("Samantha Panda", "This is amazing!");
        videos[2].AddComment("Jane Austow", "Keep it up!");

        videos[3].AddComment("Malcolm Why", "Awesome video!");
        videos[3].AddComment("Robert Loanlean", "I enjoyed every bit of it.");

        // Displaying information for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}