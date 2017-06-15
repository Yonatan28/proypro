using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class gastos
    {
        string identificacion;
        string nombre;
        string tipodereparto;

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

        public string Tipodereparto
        {
            get
            {
                return tipodereparto;
            }

            set
            {
                tipodereparto = value;
            }
        }
    }
}
