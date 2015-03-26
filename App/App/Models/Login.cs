using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fakeUserLoginKey { get; set; }
        /// user exists
        [Display(Name = "Name")]
        public string UserName { get; set; }
        [Display(Name = "Passowrd")]
        public string UserPassword { get; set; }
         
    }
}