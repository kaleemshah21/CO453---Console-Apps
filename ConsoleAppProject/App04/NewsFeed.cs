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
    /// 
    ///</summary>
    ///<author>
    ///  Kaleem Shah
    ///  version 0.8
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

        public Post Post
        {
            get => default;
            set
            {
            }
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed, prints the news feed details to the
        /// terminal.
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

       
        /*finds a post from the postid and returns the post*/
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

        /*adds a comment to the post*/
        public void addComment(Post post)
        {
            string message = ConsoleHelper.DisplayMessage("\n Please enter your comment: ");
            post.AddComment(message);
        }

        /*allows user to choose a post id, it also checks for a valid input,
         then returns the postid*/
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

        /*removes the post and displays a success message*/
        public void RemovePosts(Post postToRemove, int postId)
        {
            
            
            posts.Remove(postToRemove);
            Console.WriteLine($" Post with ID {postId} removed successfully.");
            Console.WriteLine();
            Display();
        }

        /*displays all posts from the user that is passed through*/
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

        /*adds a like to the post*/
        public void addLike(Post postToLike)
        {
            postToLike.Like();
        }

        /*removes a like from the post*/
        internal void Unlike(Post postToUnlike)
        {
            postToUnlike.Unlike();
        }
    }

}
