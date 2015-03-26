using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Login
    {
        /// user exists
        [Display(Name = "Name")]
        public string UserName { get; set; }
        [Display(Name = "Passowrd")]
        public string UserPassword { get; set; }
         
    }
}