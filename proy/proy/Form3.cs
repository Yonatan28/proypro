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
    public partial class Form3 : Form
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<gastos> listagastos = new List<gastos>();
        List<propiedades> listapropiedades = new List<propiedades>();
        List<piso> listapiso = new List<piso>();
        List<garaje> listagaraje = new List<garaje>();
        List<local> listalocal = new List<local>();
        List<Propietarios> listapropietarios = new List<Propietarios>();
        List<gastos2> listagastos2 = new List<gastos2>();
        List<listavistapropietarios> listavistapro = new List<listavistapropietarios>();
        public Form3()
        {
            InitializeComponent();
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
            cargargastos2();
           
            int numr = 1;
            for (int i = 0; i < listalocal.Count; i++)
            {
                for (int j = 0; j < listapropietarios.Count; j++)
                {
                    if (listalocal[i].Nit==listapropietarios[j].Nit)
                    {
                        listavistapropietarios protmp = new listavistapropietarios();
                        protmp.Codigo = listalocal[i].Codigoidentificacion;
                        protmp.Me2 = Convert.ToString(listalocal[i].Metroscuadros);
                        protmp.N = numr++;
                        protmp.Nombrepropie = listapropietarios[j].Nombre;
                        protmp.Infoadicional = listalocal[i].Nombrecomercial + "," + listalocal[i].Actividad;
                        int resultado =  Convert.ToInt32(listalocal[i].Porcentajes[i].Split('-').Last());
                        string tipo= listalocal[i].Porcentajes[i].Split('-').ElementAt(0);
                        int sumaimporte=0;
                        for (int f = 0; f < listagastos2.Count; f++)
                        {
                            if (tipo ==listagastos2[f].Tipodereparto)
                            {
                                sumaimporte = Convert.ToInt32(listagastos2[f].Importe) + sumaimporte;
                               

                            }
                        }
                        double por = (Convert.ToDouble(resultado) / 100);
                        double totalcuota = Convert.ToDouble(sumaimporte) * por;
                        protmp.Cuotas = Convert.ToString(totalcuota);
                        listavistapro.Add(protmp);
                    }
                  

                }
                
            }
            for (int i = 0; i < listagaraje.Count; i++)
            {
                for (int j = 0; j < listapropietarios.Count; j++)
                {
                    if (listagaraje[i].Nit == listapropietarios[j].Nit)
                    {
                        listavistapropietarios protmp = new listavistapropietarios();
                        protmp.Codigo = listagaraje[i].Codigoidentificacion;
                        protmp.Me2 = Convert.ToString(listagaraje[i].Metroscuadros);
                        protmp.N = numr++;
                        protmp.Nombrepropie = listapropietarios[j].Nombre;
                        protmp.Infoadicional = listagaraje[i].Abierta + "," + listagaraje[i].Bodega;
                        int resultado = Convert.ToInt32(listagaraje[i].Porcentajes[0].Split('-').Last());
                        string tipo = listagaraje[i].Porcentajes[0].Split('-').ElementAt(0);
                        int sumaimporte = 0;
                        for (int f = 0; f < listagastos2.Count; f++)
                        {
                            if (tipo == listagastos2[f].Tipodereparto)
                            {
                                sumaimporte = Convert.ToInt32(listagastos2[f].Importe) + sumaimporte;


                            }
                        }
                        double por = (Convert.ToDouble(resultado) / 100);
                        double totalcuota = Convert.ToDouble(sumaimporte) * por;
                        protmp.Cuotas = Convert.ToString(totalcuota);
                        listavistapro.Add(protmp);
                    }


                }

            }
            for (int i = 0; i < listapiso.Count; i++)
            {
                for (int j = 0; j < listapropietarios.Count; j++)
                {
                    if (listapiso[i].Nit == listapropietarios[j].Nit)
                    {
                        listavistapropietarios protmp = new listavistapropietarios();
                        protmp.Codigo = listapiso[i].Codigoidentificacion;
                        protmp.Me2 = Convert.ToString(listapiso[i].Metroscuadros);
                        protmp.N = numr++;
                        protmp.Nombrepropie = listapropietarios[j].Nombre;
                        protmp.Infoadicional = listapiso[i].Vhvn + "," + listapiso[i].Habitacion;
                        int resultado = Convert.ToInt32(listapiso[i].Porcentajes[0].Split('-').Last());
                        string tipo = listapiso[i].Porcentajes[0].Split('-').ElementAt(0);
                        int sumaimporte = 0;
                        for (int f = 0; f < listagastos2.Count; f++)
                        {
                            if (tipo == listagastos2[f].Tipodereparto)
                            {
                                sumaimporte = Convert.ToInt32(listagastos2[f].Importe) + sumaimporte;


                            }
                        }
                        double por = (Convert.ToDouble(resultado) / 100);
                        double totalcuota = Convert.ToDouble(sumaimporte) * por;
                        protmp.Cuotas = Convert.ToString(totalcuota);
                        listavistapro.Add(protmp);
                    }


                }

            }
            int totalpropidads = listagaraje.Count() + listalocal.Count() + listapiso.Count();
            textBox1.Text = Convert.ToString(totalpropidads);
            mostrar();
        }
        public void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = listavistapro;
            dataGridView1.Refresh();
        }
    }
}
