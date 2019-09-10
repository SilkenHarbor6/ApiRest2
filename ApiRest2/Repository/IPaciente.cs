using ApiRest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest2.Repository
{
    public interface IPaciente
    {
        //Definicion de los metodos
        IEnumerable<Paciente> GetAll();
        Paciente GetById(int id);
        //ClienteT GetByName(string name);
        Paciente Post(Paciente item);
        bool Delete(int id);
        bool Put(int id, Paciente item);
    }
}
