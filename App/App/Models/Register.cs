using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }


        /// <summary>
        /// phone number for recovery option 
        /// </summary>
        [Required]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        //[StringLength(10)] i.e 0871300373
        [MaxLength(10)]
        [MinLength(10)]
        public string PhoneNumber { get; set; }
        
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Passoword { get; set; }

        public System.DateTime DateCreated { get; set; }

    }
}