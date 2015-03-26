using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatDyaThink.Models
{
    /// <summary>
    /// The porpose of a composite class is to allow multiple models
    /// </summary>
    public class compositeModel
    {
        public Survey Survey { get; set; }
        public Question Question { get; set; }

        public Responces Responce { get; set; }
        public int editIdToPass { get; set; }
    }
}