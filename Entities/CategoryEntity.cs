using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CategoryEntity
    {


        // crear propiedades -key llave primaria - dataannotation
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }





        public CategoryEntity()
        {
        }
    }
}
