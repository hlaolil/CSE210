using System;
using System.Collections.Generic;

public class Video
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

