using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InputOutputEntity
    {

        [Key]
        [StringLength(50)]
        public string InoutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }

       // relacion con producto
       public ICollection<ProductEntity> Products { get; set; }


        // relacion con storage
        public String StorageId { get; set; }
        public StorageEntity Storage { get; set; }




        public InputOutputEntity()
        {
        }
    }
}
