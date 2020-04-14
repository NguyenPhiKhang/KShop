using System;
using System.ComponentModel.DataAnnotations;

namespace KShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        public DateTime? CreateDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        public string UpdatedBy { set; get; }
        public bool Status { set; get; }
    }
}