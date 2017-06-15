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
        private void button1_Click(object sender, EventArgs e)
        {
            cargarcomu();
            cargargastos();
            textBox1.Text = listacomunidad[0].Nombre;
            textBox2.Text = Convert.ToString(listagastos.Count());

        }
    }
}
