using System;
using System.ComponentModel.DataAnnotations;
namespace WebApps.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        //name must be max length 20
        [StringLength(20), Required]
        public string Name { get; set; }

        //data validation of mark
        [Range(0,100)]
        public int Mark {  get; set; }
    }
}
