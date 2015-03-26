using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WhatDyaThink.Models
{
    public class Responces
    {
        ///
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int responceID { get; set; }
        public int questionID { get; set; }
        [Display(Name = "Type")]
        public string responceType { get; set; }
        [Display(Name = "Text")]
        public string responceText { get; set; }
        [Display(Name = "CSS")]
        public string responceCSS { get; set; }
        [Display(Name = "True or False")]
        public bool responceValue { get; set; }

        //public virtual ICollection<Question> questionResponces { get; set; }
        public virtual Question Question { get; set; }

    }

    //public enum ResponceType
    //{
    //    CheckBox, RadioButton, Rainbow
    //}
}