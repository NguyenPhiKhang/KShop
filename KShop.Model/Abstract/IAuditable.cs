using System;

namespace KShop.Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        DateTime? CreateDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdatedBy { set; get; }
        bool Status { set; get; }
    }
}