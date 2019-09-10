using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiRest2.Models;

namespace ApiRest2.Repository
{
    public class RPaciente : IPaciente
    {
        private Model1 c = new Model1();

        public bool Delete(int id)
        {
            var resp = c.Paciente.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Paciente.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Paciente> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Paciente.ToList();
            }
        }

        public Paciente GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Paciente.Find(id);
        }

        public Paciente Post(Paciente item)
        {
            if (item == null)
            {
                return null;
            }
            c.Paciente.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Paciente item)
        {
            var resp = c.Paciente.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.Apellidos = item.Apellidos;
            resp.Edad = item.Edad;
            resp.Nombres = item.Nombres;
            resp.Telefono = item.Telefono;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}