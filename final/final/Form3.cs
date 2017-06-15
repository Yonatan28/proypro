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
    public partial class Form3 : Form
    {
        List<compras> listacompras = new List<compras>();
        List<productos> listaproductos = new List<productos>();
        List<listavista2> listavista = new List<listavista2>();

        public Form3()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = listavista;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listacompras.RemoveRange(0, listacompras.Count);
            listaproductos.RemoveRange(0, listaproductos.Count);
            listavista.RemoveRange(0, listavista.Count);
            cargarcom();
            cargarpro();

            string nom = textBox1.Text;
            for (int i = 0; i < listaproductos.Count; i++)
            {
                
                if (listaproductos[i].Nombre == nom)
                {
                    
                    for (int j = 0; j < listacompras.Count; j++)
                    {
                        if (listaproductos[i].Codigo == listacompras[j].Codigoproducto)
                        {
                            listavista2 vistmp = new listavista2();
                            vistmp.Mes = listacompras[j].Mescompra;
                            vistmp.Precio = listacompras[j].Preciocompra;
                            listavista.Add(vistmp);
                        }
                            

                        }
                   

                }
                
            }
            mostrar();
        }
        int i; int totaltodo;
        private void button2_Click(object sender, EventArgs e)
        {
            
                listacompras.RemoveRange(0, listacompras.Count);
                listaproductos.RemoveRange(0, listaproductos.Count);
                listavista.RemoveRange(0, listavista.Count);
                cargarcom();
                cargarpro();
                
                for (i = 0; i < listacompras.Count; i++)
                {
                    totaltodo = listacompras[i].totalcom()+totaltodo;
                }
                textBox2.Text = Convert.ToString(totaltodo);
            
        }
    }
}
