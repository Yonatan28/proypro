using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class vistapropi
    {
        string codigo;
        string nombre;
        string email;
        string propiedades;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Propiedades
        {
            get
            {
                return propiedades;
            }

            set
            {
                propiedades = value;
            }
        }
    }
}
