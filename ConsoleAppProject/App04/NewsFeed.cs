using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private readonly List<Post> posts;
        public const string AUTHOR = "Kaleem";
        
        

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "This is a test");
            AddMessagePost(post);
            PhotoPost photopost = new PhotoPost(AUTHOR, "Photo.jpg", "This is also a test");
            AddPhotoPost(photopost);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            List<Post> sortedPosts = posts.OrderBy(post => post.Timestamp).ToList();

            // display all text posts
            foreach (Post post in sortedPosts)
            {
                Console.WriteLine();
                post.Display();
                
            }

        }

       

        public Post FindPost(int ID)
        {
            foreach(Post post in posts)
            {
                if(post.postId == ID)
                {
                    return post;
                }
            }
            
            return null;

        }

        public void addComment(Post post)
        {
            string message = ConsoleHelper.DisplayMessage("\n Please enter your comment: ");
            post.AddComment(message);
        }

        public int ChoosePostId(string prompt)
        {
            Display(); // Display all posts
            int postId;


            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out postId) || postId < 1)
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid Post ID: ");

            }
            return postId;
        }

        public void RemovePosts(Post postToRemove, int postId)
        {
            
            
            posts.Remove(postToRemove);
            Console.WriteLine($" Post with ID {postId} removed successfully.");
            Console.WriteLine();
            Display();
        }

        public void DisplayPostFromUser(string user)
        {


            List<Post> userPosts = posts.Where(post => post.Username.Equals(user, StringComparison.OrdinalIgnoreCase)).ToList();
            if (userPosts.Count > 0){
                foreach (Post post in userPosts)
                {
                    Console.WriteLine();
                    post.Display();
                      
                }
            }
            else
            {
                Console.WriteLine(" There are no Posts by that User ");
                Console.WriteLine();
            }

        }

        public void addLike(Post postToLike)
        {
            postToLike.Like();
        }

        internal void Unlike(Post postToUnlike)
        {
            postToUnlike.Unlike();
        }
    }

}
