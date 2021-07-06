using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jimmy_Purnell_Development.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a project name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a project description.")]
        public string Description { get; set; }
        public string Url { get; set; }
        [Required(ErrorMessage = "Please enter a project GitHub Url.")]
        public string GitHub { get; set; }
        public string ScreenShot { get; set; }
        public virtual ICollection<ProjectComments> ProjectComment { get; set; }
    }
}
