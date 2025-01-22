namespace AdoNetCorePractica
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
            label1 = new Label();
            cmbHospitales = new ComboBox();
            label2 = new Label();
            txtSumaSalarial = new TextBox();
            label3 = new Label();
            txtMediaSalarial = new TextBox();
            txtPersonas = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(52, 75);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(139, 27);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 159);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 2;
            label2.Text = "Suma Salarial";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(61, 193);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(115, 26);
            txtSumaSalarial.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 246);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 4;
            label3.Text = "Media Salarial";
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(61, 282);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(115, 26);
            txtMediaSalarial.TabIndex = 5;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(61, 373);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(115, 26);
            txtPersonas.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 337);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 6;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 37);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 8;
            label5.Text = "Empleados Hospital";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(330, 75);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(342, 327);
            lstEmpleados.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMediaSalarial);
            Controls.Add(label3);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private TextBox txtSumaSalarial;
        private Label label3;
        private TextBox txtMediaSalarial;
        private TextBox txtPersonas;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
    }
}
