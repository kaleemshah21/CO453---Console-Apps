using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Kaleem's NewsFeed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Display All Posts", "Quit"
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
                    case 4:  break;
                    case 5:  break;
                    case 7: wantToQuit = true; break;
                }
            }while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostMessage()
        {
            string name = ConsoleHelper.DisplayMessage("\n Please enter your name: ");
            
            
            string message = ConsoleHelper.DisplayMessage("\n Please enter your message: ");
            MessagePost newMessagePost = new MessagePost(name, message);
            news.AddMessagePost(newMessagePost);
        }

        private void PostImage()
        {
            
            string name = ConsoleHelper.DisplayMessage("\n Please enter your name: ");
            string imageUrl = ConsoleHelper.DisplayMessage("\n Please enter your image url: ");
            while (!imageUrl.Contains(".") || (!imageUrl.EndsWith(".jpg") && !imageUrl.EndsWith(".png")))
            {
                ConsoleHelper.DisplayErrorMessage(" Invalid input. Please enter a valid URL ending with '.jpg' or '.png' : ");
                Console.Write("\n Please enter your image url: ");
                imageUrl = Console.ReadLine(); // Read the input again
            } 
            string message = ConsoleHelper.DisplayMessage("\n Please enter your message: ");
            PhotoPost newPhotoPost = new PhotoPost(name, imageUrl, message);
            news.AddPhotoPost(newPhotoPost);
        }

        
    }
}
