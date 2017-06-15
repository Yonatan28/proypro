using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proy
{
    class Propietarios
    {
        string nombre;
        string nit;
        string email;

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
    }
}
