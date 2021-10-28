using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductEntity
    {

        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(500)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        // relacion con categoria
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        // relacion producto storage
        public ICollection<StorageEntity> Storage { get; set; }



        public ProductEntity()
        {
        }
    }
}
