using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCorePractica.Models;
using AdoNetCorePractica.Repositories;

namespace AdoNetCorePractica
{
    public partial class Form2 : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form2()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.CargarDepartamentosAsync();
        }

        public async Task CargarDepartamentosAsync()
        {
            List<Departamentos> departamentos = await this.repo.GetNombreDeptAsync();

            this.cmbDepartamentos.Items.Clear();

            foreach (Departamentos dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.Nombre);
            }
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Departamentos> departamentos = await this.repo.GetNombreDeptAsync();

            foreach (Departamentos dept in departamentos)
            {
                if (this.cmbDepartamentos.SelectedItem.ToString() == dept.Nombre)
                {
                    this.txtId.Text = dept.Id.ToString();
                    this.txtNombre.Text = dept.Nombre;
                    this.txtLocalidad.Text = dept.Localidad;
                }
            }

            Empleados datosEmpleados = await this.repo.GetEmpleadosAsync(this.cmbDepartamentos.SelectedItem.ToString());

            this.lstEmpleados.Items.Clear();

            foreach (Empleados dato in datosEmpleados)
            {
                this.lstEmpleados.Items.Add(dato.Apellido + " - " + dato.Especialidad + " - " + dato.Salario);
            }
        }

        private async void btnInsertDept_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.InsertDepartamentoAsync(id, nombre, localidad);
            this.CargarDepartamentosAsync();
        }
    }
}
