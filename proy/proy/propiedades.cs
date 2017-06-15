using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class propiedades
    {
        string tipodepropiedad;
        string codigoidentificacion;
        int metroscuadros;
        string nit;
        List<string> porcentajes;
        List<string> gastos;
      

        public string Tipodepropiedad
        {
            get
            {
                return tipodepropiedad;
            }

            set
            {
                tipodepropiedad = value;
            }
        }

        public string Codigoidentificacion
        {
            get
            {
                return codigoidentificacion;
            }

            set
            {
                codigoidentificacion = value;
            }
        }

        public int Metroscuadros
        {
            get
            {
                return metroscuadros;
            }

            set
            {
                metroscuadros = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public List<string> Porcentajes
        {
            get
            {
                return porcentajes;
            }

            set
            {
                porcentajes = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }


    }
}
