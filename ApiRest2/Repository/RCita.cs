using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiRest2.Models;

namespace ApiRest2.Repository
{
    public class RCita : ICita
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Cita.Find(id);
            if (resp==null)
            {
                return false;
            }
            c.Cita.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public Cita Post(Cita item)
        {
            if (item == null)
            {
                return null;
            }
            try
            {
                c.Cita.Add(item);
                c.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Put(int id, Cita item)
        {
            var cita = c.Cita.Find(id);
            if (cita == null)
            {
                return false;
            }
            cita.id_Cita = item.id_Cita;
            cita.id_Paciente = item.id_Paciente;
            cita.FechaCita = item.FechaCita;
            c.Entry(cita).State = System.Data.Entity.EntityState.Modified;
            return true;
        }
    }
}