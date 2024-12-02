using System;
using System.Collections.Generic;

namespace YouTubeTracking
{
    // Comment class to store comment details
    class Comment
    {
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        // Constructor
        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }
    }

    // Video class to store video details and manage comments
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        private List<Comment> comments = new List<Comment>();

        // Constructor
        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
        }

        // Method to add a comment to the video
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        // Method to get the number of comments
        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        // Method to display all comments
        public void DisplayComments()
        {
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }
        }
    }

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
}
