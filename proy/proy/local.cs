using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class local:propiedades
    {
        string nombrecomercial;
        string actividad;

        public string Nombrecomercial
        {
            get
            {
                return nombrecomercial;
            }

            set
            {
                nombrecomercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
