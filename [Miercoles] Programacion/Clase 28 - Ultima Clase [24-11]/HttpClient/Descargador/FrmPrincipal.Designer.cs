
namespace Downloader
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDescargar = new System.Windows.Forms.Button();
            this.rchDescarga = new System.Windows.Forms.RichTextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(12, 40);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(145, 96);
            this.btnDescargar.TabIndex = 0;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // rchDescarga
            // 
            this.rchDescarga.Location = new System.Drawing.Point(163, 40);
            this.rchDescarga.Name = "rchDescarga";
            this.rchDescarga.Size = new System.Drawing.Size(614, 96);
            this.rchDescarga.TabIndex = 1;
            this.rchDescarga.Text = "";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(163, 12);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(614, 23);
            this.txtLink.TabIndex = 2;
            this.txtLink.Text = "https://www.multiledmkt.com.ar/ws_mocks/test";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLink.Location = new System.Drawing.Point(79, 12);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(67, 25);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "Link ->";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 143);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.rchDescarga);
            this.Controls.Add(this.btnDescargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.RichTextBox rchDescarga;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLink;
    }
}

