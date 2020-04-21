﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KShop.Model.Models
{
    [Table("Error")]
    public class Error
    {
        public int ID { set; get; }
        public string Message { set; get; }
        public string StackTrace { set; get; }
        public DateTime CreateDate { set; get; }
    }
}