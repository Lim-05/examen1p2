namespace examen1p2
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbCelcius = new System.Windows.Forms.Label();
            this.lbFahrenheit = new System.Windows.Forms.Label();
            this.btEncender = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(23, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(23, 68);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(73, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(73, 65);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(100, 20);
            this.tbFecha.TabIndex = 3;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(73, 111);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // lbCelcius
            // 
            this.lbCelcius.AutoSize = true;
            this.lbCelcius.Location = new System.Drawing.Point(298, 29);
            this.lbCelcius.Name = "lbCelcius";
            this.lbCelcius.Size = new System.Drawing.Size(43, 13);
            this.lbCelcius.TabIndex = 5;
            this.lbCelcius.Text = "Celsius:";
            // 
            // lbFahrenheit
            // 
            this.lbFahrenheit.AutoSize = true;
            this.lbFahrenheit.Location = new System.Drawing.Point(298, 72);
            this.lbFahrenheit.Name = "lbFahrenheit";
            this.lbFahrenheit.Size = new System.Drawing.Size(60, 13);
            this.lbFahrenheit.TabIndex = 6;
            this.lbFahrenheit.Text = "Fharenheit:";
            // 
            // btEncender
            // 
            this.btEncender.Location = new System.Drawing.Point(65, 231);
            this.btEncender.Name = "btEncender";
            this.btEncender.Size = new System.Drawing.Size(108, 23);
            this.btEncender.TabIndex = 7;
            this.btEncender.Text = "Encender LED";
            this.btEncender.UseVisualStyleBackColor = true;
            this.btEncender.Click += new System.EventHandler(this.btEncender_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(250, 231);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(108, 23);
            this.btApagar.TabIndex = 8;
            this.btApagar.Text = "Apagar LED";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btEncender);
            this.Controls.Add(this.lbFahrenheit);
            this.Controls.Add(this.lbCelcius);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbCelcius;
        private System.Windows.Forms.Label lbFahrenheit;
        private System.Windows.Forms.Button btEncender;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Label label1;
    }
}

