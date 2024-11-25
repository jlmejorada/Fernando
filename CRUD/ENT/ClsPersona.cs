using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsPersona
    {

        #region ATRIBUTOS Y PROPIEDADES
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Foto { get; set; } = "";
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public int IDDepartamento { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public ClsPersona()
        {
        }
        public ClsPersona(int id, string nombre, string apellidos, string telefono, string direccion, string foto, DateTime fechaNacimiento, int idDepartamento)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Foto = foto;
            FechaNacimiento = fechaNacimiento;
            IDDepartamento = idDepartamento;
        }

        public ClsPersona(ClsPersona persona)
        {
            Id = persona.Id;
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            Telefono = persona.Telefono;
            Direccion = persona.Direccion;
            Foto = persona.Foto;
            FechaNacimiento = persona.FechaNacimiento;
            IDDepartamento = persona.IDDepartamento;
        }

        #endregion

    }
}
