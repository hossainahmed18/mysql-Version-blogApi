using System;
using System.ComponentModel.DataAnnotations;

namespace blogApi.Models
{
    public class User
    {


        [Key]
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string userRole {get; set;}
        public string password {get; set;}
        

    }
}