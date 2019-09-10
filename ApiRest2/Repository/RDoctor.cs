namespace ApiRest2.Repository
{
    using ApiRest2.Models;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RDoctor : IDoctor
    {
        private Model1 c = new Model1();
        /// <summary>
        /// METODO PARA ELIMINAR EN LA DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var resp = c.Doctor.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Doctor.Remove(resp);
            c.SaveChanges();
            return true;
        }
        /// <summary>
        /// METODO GET ALL DOCTORES
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Doctor> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Doctor.ToList();
            }
        }
        /// <summary>
        /// METODO GET BY ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Doctor GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Doctor.Find(id);
        }
        /// <summary>
        /// METODO POST
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Doctor Post(Doctor item)
        {
            if (item==null)
            {
                return null;
            }
            c.Doctor.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Doctor item)
        {
            var resp = c.Doctor.Find(id);
            if (resp==null)
            {
                return false;
            }
            resp.Especialidad = item.Especialidad;
            resp.NombreCompleto = item.NombreCompleto;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}