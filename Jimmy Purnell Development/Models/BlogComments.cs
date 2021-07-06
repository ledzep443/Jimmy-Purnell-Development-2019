using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jimmy_Purnell_Development.Models
{
    public class BlogComments
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a comment.")]
        public string BlogComment { get; set; }
        public DateTime CreatedDate { get; set; }
        
    }
}