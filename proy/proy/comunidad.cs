using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class comunidad
    {
        string identificacion;
        string nombre;
        string poblacion;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
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

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}
