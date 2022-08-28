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
    public partial class menu : Form
    {

        ayuda ayuda;


        public menu()
        {
            InitializeComponent();
        }

        
        
            private void Ap_Click_1(object sender, EventArgs e)
            {
                MessageBox.Show("Usted a leido nuestros requerimientos", "Confirme porfavor");
            }

            private void Bp_Click_1(object sender, EventArgs e)
            {
                MessageBox.Show("Desearia aceptar nuestros requerimientos", "Acepte si esta de acuerdo o de cacelar si no", MessageBoxButtons.OKCancel);
            }

            private void Qp_Click_1(object sender, EventArgs e)
            {
                MessageBox.Show("Error 234", "Se cerro nuestra plataforma debido a una falta de Ram", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            private void Dp_Click_1(object sender, EventArgs e)
            {
                MessageBox.Show("Otra persona a iniciado en su cuenta", "Es usted esa persona", MessageBoxButtons.YesNoCancel);
            }

            private void Hp_Click_1(object sender, EventArgs e)
            {
                MessageBox.Show("¿Tiene coneccion a internet?", "Debe de tener coneccion a internet para utilizar nuestros servicios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

            private void Ip_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Error de incompatibilidad", "Su pc es incompatible con nuestra plataforma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca lecehe = new acerca();
            lecehe.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda abrir_ayuda = new ayuda();
            abrir_ayuda.MdiParent = this;
            abrir_ayuda.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {


        }

        private void cuadroDeDialogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted a leido nuestros requerimientos", "Confirme porfavor");
        }

        private void aceptarCancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desearia aceptar nuestros requerimientos", "Acepte si esta de acuerdo o de cacelar si no", MessageBoxButtons.OKCancel);
        }

        private void siNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otra persona a iniciado en su cuenta", "Es usted esa persona", MessageBoxButtons.YesNoCancel);
        }

        private void aceptarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error 234", "Se cerro nuestra plataforma debido a una falta de Ram", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void aceptarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Tiene coneccion a internet?", "Debe de tener coneccion a internet para utilizar nuestros servicios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void aceptarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error de incompatibilidad", "Su pc es incompatible con nuestra plataforma", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suma HH = new suma();
            HH.ShowDialog();
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ingresarUsurioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clave gg = new clave();
            gg.ShowDialog();
        }

        private void seleccionMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversor kk = new conversor();
            kk.ShowDialog();
        }

        private void modificaElTamañoDeElFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
         ultimo jj = new ultimo();
            jj.ShowDialog();

        }

       
    
             private void cmbiarColorDeFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color ff = new color();
            ff.ShowDialog();
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sensibilidadDeElMauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont ccc = new cont ();
            ccc.ShowDialog();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tienda COC = new Tienda();
            COC.ShowDialog();
        }
    }

    }
    


    
    
    
    
    
                
                    

                    
                
    

