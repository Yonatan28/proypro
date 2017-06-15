using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class garaje:propiedades
    {
        string abierta;
        string bodega;

        public string Abierta
        {
            get
            {
                return abierta;
            }

            set
            {
                abierta = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}
