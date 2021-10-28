using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;

namespace Business
{
    public class B_Warehouse
    {




        // consulta informacion
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }

        }

        // crear
        public void CreateWarehouse(WarehouseEntity warehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(warehouse); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }


        }

        // modificar
        public void UpdateWarehouse(WarehouseEntity warehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(warehouse); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }

        }


        public B_Warehouse()
        {
        }
    }
}
