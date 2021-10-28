﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WarehouseEntity
    {

        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }


        // relacion con Storage
        public ICollection<StorageEntity> Storages  { get; set; }


        public WarehouseEntity()
        {
        }
    }
}
