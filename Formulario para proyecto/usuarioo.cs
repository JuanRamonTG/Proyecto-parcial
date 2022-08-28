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
    public partial class usuarioo : Form
    {
        public usuarioo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Ramon";
            string clave = "123";

            if(txtusuario.Text == usuario || (txtclave.Text == clave))
            {
                
                menu fprincipal = new menu();
                fprincipal.Show();  
                this.Hide();  
            }
        }

        
    }
}
