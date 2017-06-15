using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class compras
    {
        string mescompra;
        string codigoproducto;
        string preciocompra;
        string cantidadcomprada;
        int total;

        public string Mescompra
        {
            get
            {
                return mescompra;
            }

            set
            {
                mescompra = value;
            }
        }

        public string Codigoproducto
        {
            get
            {
                return codigoproducto;
            }

            set
            {
                codigoproducto = value;
            }
        }

        public string Preciocompra
        {
            get
            {
                return preciocompra;
            }

            set
            {
                preciocompra = value;
            }
        }

        public string Cantidadcomprada
        {
            get
            {
                return cantidadcomprada;
            }

            set
            {
                cantidadcomprada = value;
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = totalcom();
            }
        }

        public int totalcom()
        {
            int multi = Convert.ToInt16(cantidadcomprada) * Convert.ToInt16(preciocompra);
            return multi;
        }
    }
}
