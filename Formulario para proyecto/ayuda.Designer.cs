
namespace Formulario_para_proyecto
{
    partial class ayuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.TextBox();
            this.bup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Enabled = false;
            this.texto.Location = new System.Drawing.Point(27, 26);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(526, 273);
            this.texto.TabIndex = 0;
            this.texto.Text = "Te ayudaremos con tus servicios:";
            // 
            // bup
            // 
            this.bup.Location = new System.Drawing.Point(458, 324);
            this.bup.Name = "bup";
            this.bup.Size = new System.Drawing.Size(72, 23);
            this.bup.TabIndex = 1;
            this.bup.Text = "Ver";
            this.bup.UseVisualStyleBackColor = true;
            this.bup.Click += new System.EventHandler(this.bup_Click);
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(565, 359);
            this.Controls.Add(this.bup);
            this.Controls.Add(this.texto);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.Font = new System.Drawing.Font("Arabic Typesetting", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayuda Juegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Button bup;
    }
}