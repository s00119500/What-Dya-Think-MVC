using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WhatDyaThink.Models
{
    public class Question
    {
        /// 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int questionID { get; set; }
        /// foreign id
        public int surveyID { get; set; }

        //[Display(Name = "Name")]
        //public string questionName { get; set; }
        [Display(Name = "Type")]
        public QuestionType questionType { get; set; }
        [Display(Name = "Text")]
        public string questionText { get; set; }

        //public virtual Survey s { get; set; }
        public virtual ICollection<Responces> questionResponces { get; set; }

    }

    public enum QuestionType
    {
        CheckBox, RadioButton
    }
}