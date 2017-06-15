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

namespace final
{
    public partial class Form2 : Form
    {
        List<compras> listacompras = new List<compras>();
        List<productos> listaproductos = new List<productos>();
        List<listasl> listavista1 = new List<listasl>();

        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listacompras.RemoveRange(0,listacompras.Count);
            listaproductos.RemoveRange(0, listaproductos.Count);
            listavista1.RemoveRange(0, listavista1.Count);
            cargarcom();
            cargarpro();

            if (Convert.ToString(comboBox1.SelectedItem) == "enero" || Convert.ToString(comboBox1.SelectedItem) == "febrero" || Convert.ToString(comboBox1.SelectedItem) == "marzo" || Convert.ToString(comboBox1.SelectedItem) == "abril" || Convert.ToString(comboBox1.SelectedItem) == "mayo" || Convert.ToString(comboBox1.SelectedItem) == "junio" || Convert.ToString(comboBox1.SelectedItem) == "julio" || Convert.ToString(comboBox1.SelectedItem) == "agosto" || Convert.ToString(comboBox1.SelectedItem) == "septiembre" || Convert.ToString(comboBox1.SelectedItem) == "octubre" || Convert.ToString(comboBox1.SelectedItem) == "noviembre" || Convert.ToString(comboBox1.SelectedItem) == "diciembre")
            {
                string ms = Convert.ToString(comboBox1.SelectedItem);
                for (int i = 0; i < listacompras.Count; i++)
                {
                    listasl vistmp = new listasl();
                    for (int j = 0; j < listaproductos.Count; j++)
                    {
                       
                        if (listacompras[i].Mescompra == ms)
                        {
                           
                            if (listacompras[i].Codigoproducto == listaproductos[j].Codigo)
                            {
                              
                                vistmp.Nombr = listaproductos[j].Nombre;
                                vistmp.Cantidadcompra = listacompras[i].Cantidadcomprada;
                                
                            }
                        
                        }
                       
                    }
                    listavista1.Add(vistmp);
                }
                label1.Text = "cargado";
                mostrar();
            }
        }
        public void cargarcom()
        {
            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\final\\final\\compras.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                compras comprastmp = new compras();
                comprastmp.Mescompra = reader.ReadLine();
                comprastmp.Codigoproducto = reader.ReadLine();
                comprastmp.Preciocompra = reader.ReadLine();
                comprastmp.Cantidadcomprada = reader.ReadLine();

                listacompras.Add(comprastmp);
            }
            reader.Close();

        }
        public void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = listavista1;
            dataGridView1.Refresh();
        }
        public void cargarpro()
        {
            string fileName = "C:\\Users\\Yonatan Coti\\Source\\Repos\\proypro\\final\\final\\producto.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                productos productotmp = new productos();
                productotmp.Codigo = reader.ReadLine();
                productotmp.Nombre = reader.ReadLine();
                listaproductos.Add(productotmp);
            }
            reader.Close();
        }
    }
}
