namespace AdoNetCorePractica
{
    partial class Form2
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
            lstEmpleados = new ListBox();
            label5 = new Label();
            txtLocalidad = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            cmbDepartamentos = new ComboBox();
            label1 = new Label();
            txtSalario = new TextBox();
            label6 = new Label();
            txtOficio = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            btnInsertDept = new Button();
            btnUpdateEmp = new Button();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(221, 69);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(330, 327);
            lstEmpleados.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 31);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 18;
            label5.Text = "Empleados";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(23, 320);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(115, 26);
            txtLocalidad.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 284);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 16;
            label4.Text = "Localidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 229);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 26);
            txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 193);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 14;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 140);
            txtId.Name = "txtId";
            txtId.Size = new Size(115, 26);
            txtId.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(21, 19);
            label2.TabIndex = 12;
            label2.Text = "Id";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(14, 52);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(139, 27);
            cmbDepartamentos.TabIndex = 11;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 10;
            label1.Text = "Departamentos";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(624, 267);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(115, 26);
            txtSalario.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 231);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 24;
            label6.Text = "Salario";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(624, 176);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(115, 26);
            txtOficio.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 140);
            label7.Name = "label7";
            label7.Size = new Size(44, 19);
            label7.TabIndex = 22;
            label7.Text = "Oficio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(624, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(115, 26);
            txtApellido.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 53);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 20;
            label8.Text = "Apellido";
            // 
            // btnInsertDept
            // 
            btnInsertDept.Location = new Point(23, 363);
            btnInsertDept.Name = "btnInsertDept";
            btnInsertDept.Size = new Size(115, 57);
            btnInsertDept.TabIndex = 26;
            btnInsertDept.Text = "Insertar Departamento";
            btnInsertDept.UseVisualStyleBackColor = true;
            btnInsertDept.Click += btnInsertDept_Click;
            // 
            // btnUpdateEmp
            // 
            btnUpdateEmp.Location = new Point(624, 308);
            btnUpdateEmp.Name = "btnUpdateEmp";
            btnUpdateEmp.Size = new Size(115, 38);
            btnUpdateEmp.TabIndex = 27;
            btnUpdateEmp.Text = "Update";
            btnUpdateEmp.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateEmp);
            Controls.Add(btnInsertDept);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label5;
        private TextBox txtLocalidad;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private ComboBox cmbDepartamentos;
        private Label label1;
        private TextBox txtSalario;
        private Label label6;
        private TextBox txtOficio;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private Button btnInsertDept;
        private Button btnUpdateEmp;
    }
}