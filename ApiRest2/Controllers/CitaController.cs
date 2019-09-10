using ApiRest2.Models;
using ApiRest2.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRest2.Controllers
{
    public class CitaController : ApiController
    {
        static readonly ICita c = new RCita();
        private Model1 db = new Model1();
        //Metodo Get
        public HttpResponseMessage GetAll()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var items = db.Cita.Include(d => d.Doctor).Include(d => d.Paciente);
            if (items.Count() == 0)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay registros");
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        //Metodo Post
        public HttpResponseMessage Post(Cita item)
        {
            item = c.Post(item);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Los datos del cliente no pueden ser nulos");
            }
            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
        //Metodo Delete
        public HttpResponseMessage Delete(int id)
        {
            var item = db.Cita.Find(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun cliente con el id " + id + " para eliminar");
            }
            c.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido eliminado");
        }
        //Metodo Put
        public HttpResponseMessage Put(int id, Cita cliente)
        {
            var item = db.Cita.Find(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun cliente con el id " + id + " para actualizar");
            }
            var isPut = c.Put(id, cliente);
            if (!isPut)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified, "No ha sido posible la actualizacion");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido actualizado");
        }
    }
}
