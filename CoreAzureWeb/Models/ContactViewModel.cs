using System;
using System.ComponentModel.DataAnnotations;

namespace CoreAzureWeb.Models
{
    public class ContactViewModel
    {
        public static readonly ContactViewModel Empty = new ContactViewModel{Name = string.Empty, Email = string.Empty, Subject = string.Empty, Comment = string.Empty };
        
        [Required(ErrorMessage = "The Name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "The Email is required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "The Subject is required")]
        public string Subject { get; set; }
        
        [Required(ErrorMessage = "The Comment is required")]
        public string Comment { get; set; }
    }
}