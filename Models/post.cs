using System;
using System.ComponentModel.DataAnnotations;

namespace blogApi.Models
{
    public class Post
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string body { get; set; }
        [Required]
        public string author {get; set;}
        public string status {get; set;}
        

    }
}