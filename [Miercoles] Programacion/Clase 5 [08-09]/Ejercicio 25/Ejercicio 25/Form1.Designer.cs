
namespace Ejercicio_25
{
    partial class Form1
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
            this.txtBinarioADecimal = new System.Windows.Forms.Label();
            this.txtDecimalABinario = new System.Windows.Forms.Label();
            this.txtBoxBinarioADecimal = new System.Windows.Forms.TextBox();
            this.txtBoxDecimalABinario = new System.Windows.Forms.TextBox();
            this.btnConvertirBinarioADecimal = new System.Windows.Forms.Button();
            this.btnConvertirDecimalABinario = new System.Windows.Forms.Button();
            this.txtBinarioConvertido = new System.Windows.Forms.TextBox();
            this.txtDecimalConvertido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBinarioADecimal
            // 
            this.txtBinarioADecimal.AutoSize = true;
            this.txtBinarioADecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBinarioADecimal.Location = new System.Drawing.Point(25, 39);
            this.txtBinarioADecimal.Name = "txtBinarioADecimal";
            this.txtBinarioADecimal.Size = new System.Drawing.Size(145, 21);
            this.txtBinarioADecimal.TabIndex = 0;
            this.txtBinarioADecimal.Text = "Binario a Decimal";
            // 
            // txtDecimalABinario
            // 
            this.txtDecimalABinario.AutoSize = true;
            this.txtDecimalABinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDecimalABinario.Location = new System.Drawing.Point(25, 83);
            this.txtDecimalABinario.Name = "txtDecimalABinario";
            this.txtDecimalABinario.Size = new System.Drawing.Size(145, 21);
            this.txtDecimalABinario.TabIndex = 1;
            this.txtDecimalABinario.Text = "Decimal a Binario";
            // 
            // txtBoxBinarioADecimal
            // 
            this.txtBoxBinarioADecimal.Location = new System.Drawing.Point(185, 41);
            this.txtBoxBinarioADecimal.Name = "txtBoxBinarioADecimal";
            this.txtBoxBinarioADecimal.Size = new System.Drawing.Size(100, 23);
            this.txtBoxBinarioADecimal.TabIndex = 2;
            // 
            // txtBoxDecimalABinario
            // 
            this.txtBoxDecimalABinario.Location = new System.Drawing.Point(185, 85);
            this.txtBoxDecimalABinario.Name = "txtBoxDecimalABinario";
            this.txtBoxDecimalABinario.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDecimalABinario.TabIndex = 3;
            // 
            // btnConvertirBinarioADecimal
            // 
            this.btnConvertirBinarioADecimal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirBinarioADecimal.Location = new System.Drawing.Point(291, 41);
            this.btnConvertirBinarioADecimal.Name = "btnConvertirBinarioADecimal";
            this.btnConvertirBinarioADecimal.Size = new System.Drawing.Size(46, 23);
            this.btnConvertirBinarioADecimal.TabIndex = 4;
            this.btnConvertirBinarioADecimal.Text = "->";
            this.btnConvertirBinarioADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirBinarioADecimal.Click += new System.EventHandler(this.btnConvertirBinarioADecimal_Click);
            // 
            // btnConvertirDecimalABinario
            // 
            this.btnConvertirDecimalABinario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirDecimalABinario.Location = new System.Drawing.Point(291, 85);
            this.btnConvertirDecimalABinario.Name = "btnConvertirDecimalABinario";
            this.btnConvertirDecimalABinario.Size = new System.Drawing.Size(46, 23);
            this.btnConvertirDecimalABinario.TabIndex = 5;
            this.btnConvertirDecimalABinario.Text = "->";
            this.btnConvertirDecimalABinario.UseVisualStyleBackColor = true;
            this.btnConvertirDecimalABinario.Click += new System.EventHandler(this.btnConvertirDecimalABinario_Click);
            // 
            // txtBinarioConvertido
            // 
            this.txtBinarioConvertido.Location = new System.Drawing.Point(353, 86);
            this.txtBinarioConvertido.Name = "txtBinarioConvertido";
            this.txtBinarioConvertido.ReadOnly = true;
            this.txtBinarioConvertido.Size = new System.Drawing.Size(100, 23);
            this.txtBinarioConvertido.TabIndex = 6;
            // 
            // txtDecimalConvertido
            // 
            this.txtDecimalConvertido.Location = new System.Drawing.Point(353, 41);
            this.txtDecimalConvertido.Name = "txtDecimalConvertido";
            this.txtDecimalConvertido.ReadOnly = true;
            this.txtDecimalConvertido.Size = new System.Drawing.Size(100, 23);
            this.txtDecimalConvertido.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 145);
            this.Controls.Add(this.txtDecimalConvertido);
            this.Controls.Add(this.txtBinarioConvertido);
            this.Controls.Add(this.btnConvertirDecimalABinario);
            this.Controls.Add(this.btnConvertirBinarioADecimal);
            this.Controls.Add(this.txtBoxDecimalABinario);
            this.Controls.Add(this.txtBoxBinarioADecimal);
            this.Controls.Add(this.txtDecimalABinario);
            this.Controls.Add(this.txtBinarioADecimal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Binario Decimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtBinarioADecimal;
        private System.Windows.Forms.Label txtDecimalABinario;
        private System.Windows.Forms.TextBox txtBoxBinarioADecimal;
        private System.Windows.Forms.TextBox txtBoxDecimalABinario;
        private System.Windows.Forms.Button btnConvertirBinarioADecimal;
        private System.Windows.Forms.Button btnConvertirDecimalABinario;
        private System.Windows.Forms.TextBox txtBinarioConvertido;
        private System.Windows.Forms.TextBox txtDecimalConvertido;
    }
}

