
namespace Crocco.LucianoAgustin._2C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lstEjercito = new System.Windows.Forms.ListBox();
            this.picStormtrooperHelmet = new System.Windows.Forms.PictureBox();
            this.lblArmamento = new System.Windows.Forms.Label();
            this.cmbArmamento = new System.Windows.Forms.ComboBox();
            this.lblEsClon = new System.Windows.Forms.Label();
            this.chkEsClon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(12, 14);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(224, 50);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Location = new System.Drawing.Point(12, 410);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(224, 50);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Arena",
            "Asalto",
            "Explorador"});
            this.cmbTipo.Location = new System.Drawing.Point(12, 37);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(224, 23);
            this.cmbTipo.TabIndex = 3;
            // 
            // lstEjercito
            // 
            this.lstEjercito.FormattingEnabled = true;
            this.lstEjercito.ItemHeight = 15;
            this.lstEjercito.Location = new System.Drawing.Point(242, 14);
            this.lstEjercito.Name = "lstEjercito";
            this.lstEjercito.Size = new System.Drawing.Size(534, 454);
            this.lstEjercito.TabIndex = 4;
            // 
            // picStormtrooperHelmet
            // 
            this.picStormtrooperHelmet.Image = global::Crocco.LucianoAgustin._2C.Properties.Resources.stormtrooper;
            this.picStormtrooperHelmet.Location = new System.Drawing.Point(52, 186);
            this.picStormtrooperHelmet.Name = "picStormtrooperHelmet";
            this.picStormtrooperHelmet.Size = new System.Drawing.Size(140, 137);
            this.picStormtrooperHelmet.TabIndex = 5;
            this.picStormtrooperHelmet.TabStop = false;
            // 
            // lblArmamento
            // 
            this.lblArmamento.AutoSize = true;
            this.lblArmamento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArmamento.Location = new System.Drawing.Point(12, 63);
            this.lblArmamento.Name = "lblArmamento";
            this.lblArmamento.Size = new System.Drawing.Size(88, 20);
            this.lblArmamento.TabIndex = 6;
            this.lblArmamento.Text = "Armamento";
            // 
            // cmbArmamento
            // 
            this.cmbArmamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArmamento.FormattingEnabled = true;
            this.cmbArmamento.Items.AddRange(new object[] {
            "E11",
            "EC17",
            "DLT19"});
            this.cmbArmamento.Location = new System.Drawing.Point(12, 86);
            this.cmbArmamento.Name = "cmbArmamento";
            this.cmbArmamento.Size = new System.Drawing.Size(224, 23);
            this.cmbArmamento.TabIndex = 7;
            // 
            // lblEsClon
            // 
            this.lblEsClon.AutoSize = true;
            this.lblEsClon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEsClon.Location = new System.Drawing.Point(12, 112);
            this.lblEsClon.Name = "lblEsClon";
            this.lblEsClon.Size = new System.Drawing.Size(69, 20);
            this.lblEsClon.TabIndex = 8;
            this.lblEsClon.Text = "¿Es clon?";
            // 
            // chkEsClon
            // 
            this.chkEsClon.AutoSize = true;
            this.chkEsClon.Location = new System.Drawing.Point(85, 117);
            this.chkEsClon.Name = "chkEsClon";
            this.chkEsClon.Size = new System.Drawing.Size(15, 14);
            this.chkEsClon.TabIndex = 9;
            this.chkEsClon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 472);
            this.Controls.Add(this.chkEsClon);
            this.Controls.Add(this.lblEsClon);
            this.Controls.Add(this.cmbArmamento);
            this.Controls.Add(this.lblArmamento);
            this.Controls.Add(this.picStormtrooperHelmet);
            this.Controls.Add(this.lstEjercito);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a la fábrica de troopers del Lado Oscuro";
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ListBox lstEjercito;
        private System.Windows.Forms.PictureBox picStormtrooperHelmet;
        private System.Windows.Forms.Label lblArmamento;
        private System.Windows.Forms.ComboBox cmbArmamento;
        private System.Windows.Forms.Label lblEsClon;
        private System.Windows.Forms.CheckBox chkEsClon;
    }
}

