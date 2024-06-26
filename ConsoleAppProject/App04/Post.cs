﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{

    /*initialises variables*/
    public class Post
    {
        private static int instances = 0;

        public int postId;

        public int likes;

        private readonly List<String> comments;


        // username of the post's author
        public String Username { get; }
        public DateTime Timestamp { get; }

        /*constructor to initialise the post properties,
         it also increments a variable tto keep track of 
        total number of posts*/
        public Post(string author)
        {
            instances++;
            postId = instances;
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

       
        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Display the details of this post.
        /// 
        ///</summary>
        public virtual void Display()
        {
            
            Console.WriteLine($"    Author: {Username}");
            //Console.WriteLine($"    Message: {Message}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine($"    PostID: {postId}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                foreach (string comment in comments)
                {
                    Console.WriteLine($"    {comment}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }


        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

    }
}
