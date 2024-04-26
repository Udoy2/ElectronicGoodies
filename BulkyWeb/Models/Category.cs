using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }



        [Required]
        [MaxLength(100,ErrorMessage ="Max length must be 100 char long")]
        [DisplayName("Category Name")]
        public String Name { get; set; }



        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="order range must be under 1-100")]
        public int DisplayOrder { get; set; }
    }
}
