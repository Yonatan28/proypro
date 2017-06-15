using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class gastos2
    {
       string idgasto;
        string descripción;
        string importe;
        string tipodereparto;

        public string Idgasto
        {
            get
            {
                return idgasto;
            }

            set
            {
                idgasto = value;
            }
        }

        public string Descripción
        {
            get
            {
                return descripción;
            }

            set
            {
                descripción = value;
            }
        }

        public string Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
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
