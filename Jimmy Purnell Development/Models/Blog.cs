using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jimmy_Purnell_Development.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public int BlogId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Post { get; set; }
        public ICollection<BlogComments> BlogComments { get; set; }
    }

}
