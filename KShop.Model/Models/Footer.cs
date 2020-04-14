using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string content { set; get; }
    }
}