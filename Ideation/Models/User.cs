using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ideation.Models
{
    public class User
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter username"), MaxLength(30)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password"), MaxLength(30)]
        public string Password { get; set; }

        public string Role { get; set; }
        
    }
}