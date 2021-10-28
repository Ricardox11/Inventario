using System;
using System.Collections.Generic;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_InputOutput
    {

        // consulta informacion
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InputOutputs.ToList();
            }

        }

        // crear
        public void CreateInputOutput(InputOutputEntity oInputOuput)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Add(oInputOuput); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }


        }

        // modificar
        public void UpdateInputOutput(InputOutputEntity oInputOuput)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Update(oInputOuput); // adiciona objetos
                db.SaveChanges(); // guarda cambios

            }

        }




        public B_InputOutput()
        {
        }



    }
}
