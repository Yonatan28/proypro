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
    public partial class Form2 : Form
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<gastos> listagastos = new List<gastos>();
        List<propiedades> listapropiedades = new List<propiedades>();
        List<piso> listapiso = new List<piso>();
        List<garaje> listagaraje = new List<garaje>();
        List<local> listalocal = new List<local>();
        List<Propietarios> listapropietarios = new List<Propietarios>();
        List<gastos2> listagastos2 = new List<gastos2>();

        public Form2()
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
                tipopro= reader.ReadLine();
             
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
            int totalpropidads;
            cargarcomu();
            cargargastos();
            cargargastos2();
            cargarpropidades();
            cargarpropietarios();
            textBox1.Text = listacomunidad[0].Nombre;
            textBox2.Text = Convert.ToString(listagastos.Count());
            totalpropidads = listagaraje.Count()+listalocal.Count()+listapiso.Count();
            textBox3.Text = Convert.ToString(totalpropidads);
            textBox4.Text = Convert.ToString(listapropietarios.Count());
            int importtotal=0;
            for (int i = 0; i < listagastos2.Count; i++)
            {
                importtotal = Convert.ToInt32(listagastos2[i].Importe)+importtotal;
            }
            textBox5.Text = Convert.ToString(importtotal);
        }
    }
}
