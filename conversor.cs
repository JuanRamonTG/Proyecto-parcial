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
    public partial class conversor : Form
    {
        public conversor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + "(Mario car)";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "(GTA5)";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "(Minecraft)";
            }
        }
    }
}
