using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {



        // consulta informacion
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }

        }

        // crear
        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }


        }

        // modificar
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }

        }


        // revisar si el producto ya existe
        public static bool IsProductInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {

                // revisa si existe el producto con almacenamiento
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);

                return product.Any(); // revisa si existe



            }
        }

        // consulta informacion
        public static List<StorageEntity> GetStorageProductByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product) // incluye el objeto product de la entidad storage
                    .Include(s => s.Wherehouse)
                    .Where(s => s.WherehouseId == idWarehouse)
                    .ToList();
            }

        }


        public B_Storage()
        {
        }
    }
}
