
namespace Form_Centralita
{
    partial class FrmMostrar
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
            this.rchListaLlamadas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchListaLlamadas
            // 
            this.rchListaLlamadas.Location = new System.Drawing.Point(0, 0);
            this.rchListaLlamadas.Name = "rchListaLlamadas";
            this.rchListaLlamadas.Size = new System.Drawing.Size(466, 249);
            this.rchListaLlamadas.TabIndex = 0;
            this.rchListaLlamadas.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 249);
            this.Controls.Add(this.rchListaLlamadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Llamadas";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchListaLlamadas;
    }
}