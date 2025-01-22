using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using AdoNetCorePractica.Models;
using AdoNetCorePractica.Helpers;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region STORED PROCEDURES
/*
 
 create procedure SP_TODOS_DEPARTAMENTOS
as 
	select DNOMBRE from DEPT 
go 

create procedure SP_EMP_DEPARTAMENTOS (@dept_no int)
as 
	select * from EMP where DEPT_NO=@dept_no
go 
 
 */
#endregion

namespace AdoNetCorePractica.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = HelpersConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Departamentos>> GetNombreDeptAsync()
        {
            string sql = "SP_TODOS_DEPARTAMENTOS";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();

            List<Departamentos> departamentos = new List<Departamentos>();

            while (await this.reader.ReadAsync())
            {
                int dept_no = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                Departamentos dept = new Departamentos();
                dept.Id=dept_no;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                departamentos.Add(dept);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return departamentos;
        }

        public async Task InsertDepartamentoAsync(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@id, @nombre, @localidad)";
            
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task<List<Empleados>> GetEmpleadosAsync(string dept_no)
        {
            string sql = "SP_EMP_DEPARTAMENTOS";

            this.com.Parameters.AddWithValue("dept_no", dept_no);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();

            List<Empleados> empleados = new List<Empleados>();

            while (await this.reader.ReadAsync())
            {
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                string oficio = this.reader["OFICIO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                Empleados emp = new Empleados();
                emp.Apellido = apellido;
                emp.Especialidad = oficio;
                emp.Salario = salario;
                empleados.Add(emp);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return empleados;
        }
    }
}
