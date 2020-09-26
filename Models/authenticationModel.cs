using System;
using System.ComponentModel.DataAnnotations;

namespace blogApi.Models
{
    public class AuthenticationModel
    {

        public string email { get; set; }
        [Required]
        public string password {get; set;}
      
        

    }
}