using ApiRest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest2.Repository
{
    public interface ICita
    {
        //Definicion de los metodos
        //IEnumerable<Cita> GetAll();
        //Cita GetById(int id);
        //ClienteT GetByName(string name);
        Cita Post(Cita item);
        bool Delete(int id);
        bool Put(int id, Cita item);
    }
}
