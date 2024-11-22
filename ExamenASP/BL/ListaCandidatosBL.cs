using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListaCandidatosBL
    {
        /// <summary>
        /// Esta función extrae una lista de candidatos de la BL, 
        /// Añadiendo las siguientes politicas de empresa:
        ///     - Misiones dif 1 y 2: solo gente de USA
        ///     - Misiones dif 3: solo gente de USA > 40 años
        ///     - Misiones dif 4: solo por gente de italia < 45 años
        ///     - Misiones dif 5: solo por gente de italia > 45 < 55
        /// </summary>
        /// <returns>Lista de candidatos</returns>
        public static List<ClsCandidato> extraeCandidatosBL(int dififultad)
        {
            int edad = 0;
            List<ClsCandidato> res = new List<ClsCandidato>();
            List<ClsCandidato> lista = ListaCandidatosDAL.extraeCandidatosDAL();
            if (dififultad == 1 || dififultad == 2)
            {
                foreach (ClsCandidato c in lista)
                {
                    if (c.Pais == "USA")
                    {
                        res.Add(c);
                    };
                }
            } else if (dififultad == 3)
            {
                foreach (ClsCandidato c in lista)
                {
                    edad = DateTime.Now.Year - c.FechaNac.Year;
                    if (c.Pais == "USA" && edad > 40)
                    {
                        res.Add(c);
                    }
                }
            } else if (dififultad == 4)
            {
                foreach (ClsCandidato c in lista)
                {
                    edad = DateTime.Now.Year - c.FechaNac.Year;
                    if (c.Pais == "Italia" && edad < 45)
                    {
                        res.Add(c);
                    }
                }
            } else if (dififultad == 5)
            {
                foreach (ClsCandidato c in lista)
                {
                    edad = DateTime.Now.Year - c.FechaNac.Year;
                    if (c.Pais == "Italia" && edad > 45 && edad < 55)
                    {
                        res.Add(c);
                    }
                }
            }

            return res;
        }
    }
}
