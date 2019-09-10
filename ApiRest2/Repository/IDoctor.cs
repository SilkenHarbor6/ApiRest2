namespace ApiRest2.Repository
{
    using ApiRest2.Models;
    using System.Collections.Generic;
    public interface IDoctor
    {
        //Definicion de los metodos
        IEnumerable<Doctor> GetAll();
        Doctor GetById(int id);
        //ClienteT GetByName(string name);
        Doctor Post(Doctor item);
        bool Delete(int id);
        bool Put(int id, Doctor item);
    }
}
