using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMaui.Models
{
    public class ClsPersonaNombreDepartamento : ClsPersona
    {
        #region Atributos
        String nombreDepartamento;
        #endregion

        #region Propiedades
        public string NombreDepartamento
        {
            get { return nombreDepartamento; }
        }
        #endregion

        #region Constructores
        public ClsPersonaNombreDepartamento()
        {

        }

        public ClsPersonaNombreDepartamento(int id, string nombre, string apellidos, string telefono, string direccion, string foto, DateTime fechaNacimiento, int idDepartamento, List<ClsDepartamento> listaDept) : base(id, nombre, apellidos, telefono, direccion, foto, fechaNacimiento, idDepartamento)
        {
            ClsDepartamento? departamento = listaDept.Find(d => d.Id == idDepartamento);

            if (departamento != null)
            {
                nombreDepartamento = departamento.Nombre;
            }
        }
        public ClsPersonaNombreDepartamento(ClsPersona persona, List<ClsDepartamento> listaDept) : base(persona)
        {
            ClsDepartamento? departamento = listaDept.Find(d => d.Id == persona.IDDepartamento);

            if (departamento != null)
            {
                nombreDepartamento = departamento.Nombre;
            }
        }
        #endregion
    }
}
