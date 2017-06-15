using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proy
{
    public partial class Form4 : Form
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<gastos> listagastos = new List<gastos>();
        List<propiedades> listapropiedades = new List<propiedades>();
        List<piso> listapiso = new List<piso>();
        List<garaje> listagaraje = new List<garaje>();
        List<local> listalocal = new List<local>();
        List<Propietarios> listapropietarios = new List<Propietarios>();
        List<gastos2> listagastos2 = new List<gastos2>();
        List<vistapropi> listavista = new List<vistapropi>();
        public Form4()
        {
            InitializeComponent();
        }
        public void cargarcomu()
        {
            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\proy\\proy\\comunidad.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                comunidad comtemp = new comunidad();
                comtemp.Identificacion = reader.ReadLine();
                comtemp.Nombre = reader.ReadLine();
                comtemp.Poblacion = reader.ReadLine();
                listacomunidad.Add(comtemp);
            }
            reader.Close();
        }
        public void cargargastos()
        {
            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\proy\\proy\\gastos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                gastos gastmp = new gastos();
                gastmp.Identificacion = reader.ReadLine();
                gastmp.Nombre = reader.ReadLine();
                gastmp.Tipodereparto = reader.ReadLine();
                listagastos.Add(gastmp);
            }
            reader.Close();
        }
        public void cargarpropidades()
        {

            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\proy\\proy\\propiedades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string tipopro;
                tipopro = reader.ReadLine();

                if (tipopro == "L")
                {
                    int contar = 0;
                    local localtemp = new local();
                    localtemp.Tipodepropiedad = tipopro;
                    localtemp.Codigoidentificacion = reader.ReadLine();
                    localtemp.Metroscuadros = Convert.ToInt16(reader.ReadLine());
                    localtemp.Nit = reader.ReadLine();
                    string palabras = reader.ReadLine();
                    string[] dividida = palabras.Split(',');
                    List<string> por = new List<string>();
                    foreach (string s in dividida)
                    {

                        if (s.Trim() != "")
                        {
                            por.Add(s);
                            contar++;
                        }
                    }
                    localtemp.Porcentajes = por;
                    localtemp.Nombrecomercial = reader.ReadLine();
                    localtemp.Actividad = reader.ReadLine();
                    listalocal.Add(localtemp);
                }
                if (tipopro == "P")
                {
                    int contar = 0;
                    piso pistmp = new piso();
                    pistmp.Tipodepropiedad = tipopro;
                    pistmp.Codigoidentificacion = reader.ReadLine();
                    pistmp.Metroscuadros = Convert.ToInt16(reader.ReadLine());
                    pistmp.Nit = reader.ReadLine();
                    string palabras = reader.ReadLine();
                    string[] dividida = palabras.Split(',');
                    List<string> por2 = new List<string>();
                    foreach (string s in dividida)
                    {
                        if (s.Trim() != "")
                        {
                            por2.Add(s);
                            contar++;
                        }
                    }
                    pistmp.Porcentajes = por2;
                    pistmp.Vhvn = reader.ReadLine();
                    pistmp.Habitacion = reader.ReadLine();
                    listapiso.Add(pistmp);
                }
                if (tipopro == "G")
                {
                    int contar = 0;
                    garaje garatmp = new garaje();
                    garatmp.Tipodepropiedad = tipopro;
                    garatmp.Codigoidentificacion = reader.ReadLine();
                    garatmp.Metroscuadros = Convert.ToInt16(reader.ReadLine());
                    garatmp.Nit = reader.ReadLine();
                    string palabras = reader.ReadLine();
                    string[] dividida = palabras.Split(',');
                    List<string> por3 = new List<string>();
                    foreach (string s in dividida)
                    {
                        if (s.Trim() != "")
                        {
                            por3.Add(s);
                            contar++;
                        }
                    }
                    garatmp.Porcentajes = por3;
                    garatmp.Abierta = reader.ReadLine();
                    garatmp.Bodega = reader.ReadLine();
                    listagaraje.Add(garatmp);
                }
            }
            reader.Close();
        }
        public void cargarpropietarios()
        {
            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\proy\\proy\\propietarios.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Propietarios protmp = new Propietarios();
                protmp.Nombre = reader.ReadLine();
                protmp.Nit = reader.ReadLine();
                protmp.Email = reader.ReadLine();
                listapropietarios.Add(protmp);
            }
            reader.Close();
        }
        public void cargargastos2()
        {
            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\proy\\proy\\gastos2.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                gastos2 gastmp = new gastos2();
                gastmp.Idgasto = reader.ReadLine();
                gastmp.Descripción = reader.ReadLine();
                gastmp.Importe = reader.ReadLine();
                gastmp.Tipodereparto = reader.ReadLine();

                listagastos2.Add(gastmp);
            }
            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cargarpropidades();
            cargarpropietarios();
            for (int i = 0; i < listapropietarios.Count; i++)
            {
                for (int j = 0; j < listapiso.Count; j++)
                {
                   
                    if (listapropietarios[i].Nit== listapiso[j].Nit)
                    {
                        vistapropi vstamp = new vistapropi();
                        vstamp.Codigo = listapropietarios[i].Nit;
                        vstamp.Nombre = listapropietarios[i].Nombre;
                        vstamp.Propiedades = listapiso[j].Tipodepropiedad;
                        listavista.Add(vstamp);
                    }

                }
                
            }
            for (int i = 0; i < listapropietarios.Count; i++)
            {
                for (int j = 0; j < listalocal.Count; j++)
                {

                    if (listapropietarios[i].Nit == listalocal[j].Nit)
                    {
                        vistapropi vstamp = new vistapropi();
                        vstamp.Codigo = listapropietarios[i].Nit;
                        vstamp.Nombre = listapropietarios[i].Nombre;
                        vstamp.Propiedades = listalocal[j].Tipodepropiedad;
                        listavista.Add(vstamp);
                    }

                }

            }
            for (int i = 0; i < listapropietarios.Count; i++)
            {
                for (int j = 0; j < listagaraje.Count; j++)
                {

                    if (listapropietarios[i].Nit == listagaraje[j].Nit)
                    {
                        vistapropi vstamp = new vistapropi();
                        vstamp.Codigo = listapropietarios[i].Nit;
                        vstamp.Nombre = listapropietarios[i].Nombre;
                        vstamp.Propiedades = listagaraje[j].Tipodepropiedad;
                        listavista.Add(vstamp);
                    }

                }

            }
            mostrar();
        }
        public void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = listavista;
            dataGridView1.Refresh();
        }
    }
}
