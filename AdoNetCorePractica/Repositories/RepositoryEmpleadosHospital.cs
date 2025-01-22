using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using AdoNetCorePractica.Models;
using AdoNetCorePractica.Helpers;
using System.Data;

#region STORED PROCEDURES
//create procedure SP_TODOS_HOSPITALES_PRACTICA
//as 
//	select NOMBRE from HOSPITAL 
//go 

//alter procedure SP_PLANTILLA_HOSPITAL_PRACTICA
//(@nombre nvarchar(50), @suma int OUT, @media int out, @personas int OUT)
//as 
//	declare @id int
//	declare @suma1 int
//	declare @suma2 int
//	declare @media1 int
//	declare @media2 int
//	declare @personas1 int
//	declare @personas2 int

//	select @id = HOSPITAL_COD from HOSPITAL where NOMBRE = @NOMBRE
	
//	select  APELLIDO, SALARIO, ESPECIALIDAD from Doctor where HOSPITAL_COD = @id
//	union 
//	select APELLIDO, SALARIO, FUNCION from PLANTILLA where HOSPITAL_COD = @id

//	select @suma1 = sum(salario), @media1 = avg(salario), @personas1 = COUNT(APELLIDO) from DOCTOR where HOSPITAL_COD=@id
//	select @suma2 = sum(salario), @media2 = avg(salario), @personas2 = COUNT(APELLIDO) from PLANTILLA where HOSPITAL_COD=@id

//	set @suma = @suma1+@suma2
//	set @media = @media1+@media2
//	set @personas = @personas1+@personas2
//go 
#endregion

namespace AdoNetCorePractica.Repositories
{
    public class RepositoryEmpleadosHospital
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryEmpleadosHospital()
        {
            string connectionString = HelpersConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreHospitalesAsync()
        {
            string sql = "SP_TODOS_HOSPITALES_PRACTICA";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();

            List<string> hospitales = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return hospitales;
        }

        public async Task<EmpleadosHospital> GetDatosEmpleadosHospitalAsync(string nombre)
        {
            string sql = "SP_PLANTILLA_HOSPITAL_PRACTICA";

            this.com.Parameters.AddWithValue("nombre", nombre);

            SqlParameter paramSuma = new SqlParameter();
            paramSuma.ParameterName = "@suma";
            paramSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);
            paramSuma.Value = 0;

            SqlParameter paramMedia = new SqlParameter();
            paramMedia.ParameterName = "@media";
            paramMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramMedia);
            paramMedia.Value = 0;

            SqlParameter paramPersonas = new SqlParameter();
            paramPersonas.ParameterName = "@personas";
            paramPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramPersonas);
            paramPersonas.Value = 0;

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();
            EmpleadosHospital datosEmpleadosHospital = new EmpleadosHospital
            {
                DatosEmpleados = new List<Empleados>()
            };

            while (await this.reader.ReadAsync())
            {
                datosEmpleadosHospital.DatosEmpleados.Add(new Empleados
                {
                    Apellido = this.reader["APELLIDO"].ToString(),
                    Especialidad = this.reader["ESPECIALIDAD"].ToString(),
                    Salario = this.reader["SALARIO"].ToString()
                });
            }

            await this.reader.CloseAsync();

            datosEmpleadosHospital.SumaSalarial = paramSuma.Value.ToString();
            datosEmpleadosHospital.MediaSalarial = paramMedia.Value.ToString();
            datosEmpleadosHospital.Personas = paramPersonas.Value.ToString();

            await this.cn.CloseAsync();

            this.com.Parameters.Clear();

            return datosEmpleadosHospital;
        }
    }
}
