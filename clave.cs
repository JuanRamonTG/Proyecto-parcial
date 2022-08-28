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
    public partial class clave : Form
    {
        public clave()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123")
            {
                label2.Text = "Clave correcta";
            }
            else
            {
                label2.Text = "Clave incorrecta";
            }

        }

        private void clave_Load(object sender, EventArgs e)
        {

        }
    }
}
