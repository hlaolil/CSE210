using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store videos
            List<Video> videos = new List<Video>();

            // Create video objects and add comments
            Video video1 = new Video("Introduction to Programming", "Alice", 600);
            video1.AddComment(new Comment("John", "Great explanation!"));
            video1.AddComment(new Comment("Sarah", "Very helpful, thanks!"));
            video1.AddComment(new Comment("David", "Could you make a video on OOP concepts?"));

            Video video2 = new Video("Advanced C# Techniques", "Bob", 1200);
            video2.AddComment(new Comment("Ella", "This was a bit fast-paced."));
            video2.AddComment(new Comment("Mike", "I learned so much from this!"));
            video2.AddComment(new Comment("Sophia", "Can you slow down a bit next time?"));

            Video video3 = new Video("Design Patterns Simplified", "Chris", 900);
            video3.AddComment(new Comment("Liam", "Excellent content!"));
            video3.AddComment(new Comment("Emma", "This really clarified the topic for me."));
            video3.AddComment(new Comment("Noah", "Could you cover more patterns in the next video?"));

            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Display video details and their comments
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                video.DisplayComments();
                Console.WriteLine(); // Blank line for separation
            }
        }
    }

