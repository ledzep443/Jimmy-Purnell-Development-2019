using System;
using System.ComponentModel.DataAnnotations;

namespace Jimmy_Purnell_Development.Models
{
    public class ProjectComments
    {
        [Key]
        public int ProjectCommentId { get; set; }
        [Required(ErrorMessage = "Please enter at least your first name.")]
        public string Name { get; set; }
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Please enter a comment.")]
        public string ProjectComment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
