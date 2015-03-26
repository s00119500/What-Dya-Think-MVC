using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WhatDyaThink.Models
{
    public class Survey
    {
        ///
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int surveyID { get; set; }
        [Display(Name = "Name")]
        public string surveyName { get; set; }
        public virtual ICollection<Question> questionCollection { get; set; }

    }
    #region old
    //public class Question
    //{
    //    /// 
    //    public int questionID { get; set; }
    //    /// foreign id
    //    public int surveyID { get; set; }

    //    //[Display(Name = "Name")]
    //    //public string questionName { get; set; }
    //    [Display(Name = "Type")]
    //    public QuestionType questionType { get; set; }
    //    [Display(Name = "Text")]
    //    public string questionText { get; set; }
    //    public virtual ICollection<Responces> questionResponces { get; set; }

    //}

    //public enum QuestionType
    //{
    //    CheckBox, RadioButton
    //}


    //public class Responces
    //{
    //    ///
    //    public int responceID { get; set; }
    //    public int questionID { get; set; }
    //    [Display(Name = "Type")]
    //    public ResponceType responceType { get; set; }
    //    [Display(Name = "Text")]
    //    public string responceText { get; set; }
    //    [Display(Name = "CSS")]
    //    public string responceCSS { get; set; }
    //    [Display(Name = "True or False")]
    //    public bool responceValue { get; set; }

    //    public virtual Question Question { get; set; }

    //}

    //public enum ResponceType
    //{
    //    CheckBox, RadioButton, Rainbow
    //}
    #endregion

}