using System;
using System.ComponentModel.DataAnnotations;

namespace blogApi.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string commentBody { get; set; }
        [Required]
        public string commenter { get; set; }
        public int postId { get; set; }
       
        

    }
}