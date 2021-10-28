using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;

namespace Business
{
    public class B_Product
    {


        // consulta informacion
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }

        }

        // consulta byid
        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id ); // linq usar lastofdefault para tomar el ultimo
            }

        }

        // crear
        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }


        }

        // modificar
        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }

        }




        public B_Product()
        {
        }
    }
}
