using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }


        /*displays the menu, allows user to choose a function,
         and then calls the corresponding method*/
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Kaleem's NewsFeed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Display All Posts in time order", "Display posts by user", "Remove Post",
                "comment on post", "like post","dislike post", "quit"

            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices, "\n please select a choice: ");
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayPostsByUser(); break;
                    case 5: RemovePost(); break;
                    case 6: CommentPost(); break;
                    case 7: LikePost(); break;
                    case 8: DislikePost(); break;
                    case 9: wantToQuit = true; break;
                }
            }while (!wantToQuit);
        }

        
        /*allows the user to enter the id of a post they want to like,
         it then finds the post with that id and adds a like to it.*/
        private void LikePost()
        {
            int id = news.ChoosePostId(" enter the id of the post you want to like: ");
            Post postToLike = news.FindPost(id);
            if (postToLike != null)
            {
                news.addLike(postToLike);
            }
            else
            {
                Console.WriteLine(" No Post with that ID ");
            }
        }

        /*allows user to enter the id of the post they want to dislike,
         it then adds a dislike to the post*/
        private void DislikePost()
        {
            int id = news.ChoosePostId(" enter the id of the post you want to dislike: ");
            Post postToUnlike = news.FindPost(id);
            if (postToUnlike != null)
            {
                news.Unlike(postToUnlike);
                Console.WriteLine("successful");

            }
            else
            {
                Console.WriteLine(" No Post with that ID ");
            }
            Console.WriteLine();
        }

        /*allows user to choose a post with its id, it then adds the comment
         to the post*/
        private void CommentPost()
        {
            int id = news.ChoosePostId(" enter the id of the post you want to comment on: ");
            Post postToComment = news.FindPost(id);
            if(postToComment != null )
            {
                news.addComment(postToComment);
                Console.WriteLine("successful");
            }
            else
            {
                Console.WriteLine(" No Post with that ID ");
            }
            Console.WriteLine();
        }

        /*allows user to remove the post with the id that is entered*/
        private void RemovePost()
        {
            int id = news.ChoosePostId(" enter the id of the post you want to remove: ");
            Post postToRemove = news.FindPost(id);
            if (postToRemove != null )
            {
                news.RemovePosts(postToRemove, id);
                Console.WriteLine(" successful");
            }
            else
            {
                Console.WriteLine(" No Post with that ID ");
            }
            Console.WriteLine();

        }

        /*allows user to enter the name of the user, it will then
         show all posts by that username*/
        private void DisplayPostsByUser()
        {
            string username = ConsoleHelper.DisplayMessage("\n Please enter the name of the user: ");
            news.DisplayPostFromUser(username);
        }

        /*displays all posts*/
        private void DisplayAll()
        {
            news.Display();
        }

        /*user enteres their name, it then asks them to enter a message and a message post is created*/
        private void PostMessage()
        {
            string name = ConsoleHelper.DisplayMessage("\n Please enter your name: ");
            
            
            string message = ConsoleHelper.DisplayMessage("\n Please enter your message: ");
            MessagePost newMessagePost = new MessagePost(name, message);
            news.AddMessagePost(newMessagePost);
        }

        /*user enteres their name, it then asks them to enter a image and a message, then a photo post is created*/
        private void PostImage()
        {
            
            string name = ConsoleHelper.DisplayMessage("\n Please enter your name: ");
            string imageUrl = ConsoleHelper.DisplayMessage("\n Please enter your image url: ");
            while (!imageUrl.Contains(".") || (!imageUrl.EndsWith(".jpg") && !imageUrl.EndsWith(".png")))
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid URL ending with '.jpg' or '.png' : ");
                Console.Write("\n Please enter your image url: ");
                imageUrl = Console.ReadLine();
            } 
            string message = ConsoleHelper.DisplayMessage("\n Please enter your message: ");
            PhotoPost newPhotoPost = new PhotoPost(name, imageUrl, message);
            news.AddPhotoPost(newPhotoPost);
        }

        

        
    }
}
