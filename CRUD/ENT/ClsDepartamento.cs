using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsDepartamento
    {
        #region ATRIBUTOS Y PROPIEDADES
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region CONSTRUCTORES
        public ClsDepartamento()
        {
        }
        public ClsDepartamento(string nombre, string apellidos, string telefono, string direccion, string foto, DateTime fechaNacimiento, int idDepartamento)
        {
            Nombre = nombre;
        }
        #endregion
    }
}
