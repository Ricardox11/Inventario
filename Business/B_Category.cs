using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;

namespace Business
{
    public class B_Category
    {

        // Clase Negocio

        // consulta informacion
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }

        }

        // crear
        public void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(oCategory); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }


        }

        // modificar
        public void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }

        }


        public B_Category()
        {
        }
    }
}
