using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCorePractica.Repositories;
using AdoNetCorePractica.Models;

namespace AdoNetCorePractica
{
    public partial class Form1 : Form
    {
        RepositoryEmpleadosHospital repo;
        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosHospital();
            this.CargarHospitales();
        }

        public async Task CargarHospitales()
        {
            List<string> hospitales = await this.repo.GetNombreHospitalesAsync();

            this.cmbHospitales.Items.Clear();

            foreach (string nombre in hospitales)
            {
                this.cmbHospitales.Items.Add(nombre);
            }
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpleadosHospital datosEmpleados = await this.repo.GetDatosEmpleadosHospitalAsync(this.cmbHospitales.SelectedItem.ToString());

            this.lstEmpleados.Items.Clear();

            foreach (Empleados dato in datosEmpleados.DatosEmpleados)
            {
                this.lstEmpleados.Items.Add(dato.Apellido + " - " + dato.Especialidad + " - " + dato.Salario);
            }

            this.txtSumaSalarial.Text = datosEmpleados.SumaSalarial;
            this.txtMediaSalarial.Text = datosEmpleados.MediaSalarial;
            this.txtPersonas.Text = datosEmpleados.Personas;
        }
    }
}
