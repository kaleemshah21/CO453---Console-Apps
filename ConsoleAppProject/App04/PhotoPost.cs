﻿using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Kaleem Shah
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {
        

        // the name of the image file
        public String Filename { get; set; }
        
        // a one line image caption
        public String Caption { get; set; }   
        

        ///<summary>
        /// Constructor, sets up filename and caption.
        ///</summary>
        public PhotoPost(String author, String filename, String caption): base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }

        /*overides the display method to add the filename and caption*/
        public override void Display()
        {
            Console.WriteLine($"    Filename: [{Filename}]");
            Console.WriteLine($"    Caption: {Caption}");
            base.Display();

        }
    }
}
