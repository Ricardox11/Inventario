using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {

        [Key]
        [StringLength(50)]
        public String StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }


        [Required]
        public int PartialQuantity { get; set; }



        // relacion con producto
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        // relacion con bodega
        public string WherehouseId { get; set; }
        public WarehouseEntity Wherehouse { get; set; }


        // relacion con bodega
        public ICollection<InputOutputEntity> InputOutputs { get; set; }



        public StorageEntity()
        {
        }
    }
}
