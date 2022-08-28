using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_para_proyecto
{
    public partial class suma : Form
    {
        public suma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            int suma = valor1 + valor2;
            Label4.Text = suma.ToString();
        }

        private void suma_Load(object sender, EventArgs e)
        {

        }
    }
    }

