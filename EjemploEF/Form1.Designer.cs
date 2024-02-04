namespace EjemploEF
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
            this.GUARDAR = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Borrar = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.DataGridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btmLimpiar = new System.Windows.Forms.Button();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(284, 74);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.GUARDAR.TabIndex = 0;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(382, 74);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 0;
            this.Modificar.Text = "MODIFICAR";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(117, 151);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(482, 74);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 0;
            this.Borrar.Text = "BORRAR";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridId,
            this.DataGridNombre,
            this.DataGridApellido,
            this.DataGridEdad,
            this.DataGridDireccion,
            this.DataGridFechaNacimiento});
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(4, 310);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(1203, 210);
            this.dataGridViewAlumnos.TabIndex = 2;
            this.dataGridViewAlumnos.Click += new System.EventHandler(this.dataGridViewAlumnos_Click);
            // 
            // DataGridId
            // 
            this.DataGridId.DataPropertyName = "Id";
            this.DataGridId.HeaderText = "ID";
            this.DataGridId.Name = "DataGridId";
            // 
            // DataGridNombre
            // 
            this.DataGridNombre.DataPropertyName = "nombre";
            this.DataGridNombre.HeaderText = "NOMBRE";
            this.DataGridNombre.Name = "DataGridNombre";
            // 
            // DataGridApellido
            // 
            this.DataGridApellido.DataPropertyName = "apellido";
            this.DataGridApellido.HeaderText = "APELLIDO";
            this.DataGridApellido.Name = "DataGridApellido";
            // 
            // DataGridEdad
            // 
            this.DataGridEdad.DataPropertyName = "edad";
            this.DataGridEdad.HeaderText = "EDAD";
            this.DataGridEdad.Name = "DataGridEdad";
            // 
            // DataGridDireccion
            // 
            this.DataGridDireccion.DataPropertyName = "direccion";
            this.DataGridDireccion.HeaderText = "DIRECCION";
            this.DataGridDireccion.Name = "DataGridDireccion";
            // 
            // DataGridFechaNacimiento
            // 
            this.DataGridFechaNacimiento.DataPropertyName = "[fecha de nacimiento]";
            this.DataGridFechaNacimiento.HeaderText = "FECHA NACIMIENTO";
            this.DataGridFechaNacimiento.Name = "DataGridFechaNacimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(117, 177);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(117, 203);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(100, 20);
            this.TxtEdad.TabIndex = 1;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(117, 229);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccion.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(117, 125);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(95, 128);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "EDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "FECHA NACIMIENTO";
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.Location = new System.Drawing.Point(131, 96);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpiar.TabIndex = 4;
            this.btmLimpiar.Text = "LIMPIAR";
            this.btmLimpiar.UseVisualStyleBackColor = true;
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(117, 255);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateNacimiento.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.btmLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.GUARDAR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridFechaNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmLimpiar;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
    }
}

