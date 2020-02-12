namespace PracticaPruebaGity
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dnibox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.letraBOx = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dnibox
            // 
            this.dnibox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnibox.Location = new System.Drawing.Point(175, 118);
            this.dnibox.Name = "dnibox";
            this.dnibox.Size = new System.Drawing.Size(140, 27);
            this.dnibox.TabIndex = 0;
            this.dnibox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // letraBOx
            // 
            this.letraBOx.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letraBOx.Location = new System.Drawing.Point(334, 118);
            this.letraBOx.Name = "letraBOx";
            this.letraBOx.ReadOnly = true;
            this.letraBOx.Size = new System.Drawing.Size(37, 27);
            this.letraBOx.TabIndex = 2;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(175, 162);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(196, 37);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 328);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.letraBOx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dnibox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dnibox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox letraBOx;
        private System.Windows.Forms.Button ConvertButton;
    }
}

