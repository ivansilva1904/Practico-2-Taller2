namespace practico2
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
            this.L_DNI = new System.Windows.Forms.Label();
            this.L_NOMBRE = new System.Windows.Forms.Label();
            this.L_APELLIDO = new System.Windows.Forms.Label();
            this.L_NYA = new System.Windows.Forms.Label();
            this.L_ELIMINAR = new System.Windows.Forms.Label();
            this.T_DNI = new System.Windows.Forms.TextBox();
            this.T_NOMBRE = new System.Windows.Forms.TextBox();
            this.T_APELLIDO = new System.Windows.Forms.TextBox();
            this.B_GUARDAR = new System.Windows.Forms.Button();
            this.B_ELIMINAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_DNI
            // 
            this.L_DNI.AutoSize = true;
            this.L_DNI.Location = new System.Drawing.Point(114, 99);
            this.L_DNI.Name = "L_DNI";
            this.L_DNI.Size = new System.Drawing.Size(26, 13);
            this.L_DNI.TabIndex = 0;
            this.L_DNI.Text = "DNI";
            // 
            // L_NOMBRE
            // 
            this.L_NOMBRE.AutoSize = true;
            this.L_NOMBRE.Location = new System.Drawing.Point(114, 154);
            this.L_NOMBRE.Name = "L_NOMBRE";
            this.L_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.L_NOMBRE.TabIndex = 1;
            this.L_NOMBRE.Text = "Nombre";
            // 
            // L_APELLIDO
            // 
            this.L_APELLIDO.AutoSize = true;
            this.L_APELLIDO.Location = new System.Drawing.Point(114, 215);
            this.L_APELLIDO.Name = "L_APELLIDO";
            this.L_APELLIDO.Size = new System.Drawing.Size(44, 13);
            this.L_APELLIDO.TabIndex = 2;
            this.L_APELLIDO.Text = "Apellido";
            // 
            // L_NYA
            // 
            this.L_NYA.AutoSize = true;
            this.L_NYA.Location = new System.Drawing.Point(131, 29);
            this.L_NYA.Name = "L_NYA";
            this.L_NYA.Size = new System.Drawing.Size(91, 13);
            this.L_NYA.TabIndex = 3;
            this.L_NYA.Text = "Nombre y apellido";
            // 
            // L_ELIMINAR
            // 
            this.L_ELIMINAR.AutoSize = true;
            this.L_ELIMINAR.ForeColor = System.Drawing.Color.Red;
            this.L_ELIMINAR.Location = new System.Drawing.Point(280, 29);
            this.L_ELIMINAR.Name = "L_ELIMINAR";
            this.L_ELIMINAR.Size = new System.Drawing.Size(50, 13);
            this.L_ELIMINAR.TabIndex = 4;
            this.L_ELIMINAR.Text = "Modificar";
            // 
            // T_DNI
            // 
            this.T_DNI.Location = new System.Drawing.Point(253, 99);
            this.T_DNI.Name = "T_DNI";
            this.T_DNI.Size = new System.Drawing.Size(100, 20);
            this.T_DNI.TabIndex = 5;
            this.T_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_DNI_KeyPress);
            // 
            // T_NOMBRE
            // 
            this.T_NOMBRE.Location = new System.Drawing.Point(253, 151);
            this.T_NOMBRE.Name = "T_NOMBRE";
            this.T_NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.T_NOMBRE.TabIndex = 6;
            this.T_NOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_NOMBRE_KeyPress);
            // 
            // T_APELLIDO
            // 
            this.T_APELLIDO.Location = new System.Drawing.Point(253, 212);
            this.T_APELLIDO.Name = "T_APELLIDO";
            this.T_APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.T_APELLIDO.TabIndex = 7;
            this.T_APELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_APELLIDO_KeyPress);
            // 
            // B_GUARDAR
            // 
            this.B_GUARDAR.Location = new System.Drawing.Point(117, 290);
            this.B_GUARDAR.Name = "B_GUARDAR";
            this.B_GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.B_GUARDAR.TabIndex = 8;
            this.B_GUARDAR.Text = "Guardar";
            this.B_GUARDAR.UseVisualStyleBackColor = true;
            this.B_GUARDAR.Click += new System.EventHandler(this.B_GUARDAR_Click);
            // 
            // B_ELIMINAR
            // 
            this.B_ELIMINAR.Location = new System.Drawing.Point(266, 290);
            this.B_ELIMINAR.Name = "B_ELIMINAR";
            this.B_ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.B_ELIMINAR.TabIndex = 9;
            this.B_ELIMINAR.Text = "Eliminar";
            this.B_ELIMINAR.UseVisualStyleBackColor = true;
            this.B_ELIMINAR.Click += new System.EventHandler(this.B_ELIMINAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.B_ELIMINAR);
            this.Controls.Add(this.B_GUARDAR);
            this.Controls.Add(this.T_APELLIDO);
            this.Controls.Add(this.T_NOMBRE);
            this.Controls.Add(this.T_DNI);
            this.Controls.Add(this.L_ELIMINAR);
            this.Controls.Add(this.L_NYA);
            this.Controls.Add(this.L_APELLIDO);
            this.Controls.Add(this.L_NOMBRE);
            this.Controls.Add(this.L_DNI);
            this.Name = "Form1";
            this.Text = "Pequeño formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_DNI;
        private System.Windows.Forms.Label L_NOMBRE;
        private System.Windows.Forms.Label L_APELLIDO;
        private System.Windows.Forms.Label L_NYA;
        private System.Windows.Forms.Label L_ELIMINAR;
        private System.Windows.Forms.TextBox T_DNI;
        private System.Windows.Forms.TextBox T_NOMBRE;
        private System.Windows.Forms.TextBox T_APELLIDO;
        private System.Windows.Forms.Button B_GUARDAR;
        private System.Windows.Forms.Button B_ELIMINAR;
    }
}

