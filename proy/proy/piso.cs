using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class piso:propiedades
    {
        string vhvn;
        string habitacion;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public string Habitacion
        {
            get
            {
                return habitacion;
            }

            set
            {
                habitacion = value;
            }
        }
    }
}
