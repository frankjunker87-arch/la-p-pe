using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.ADO.NET
{
    public class LaPapeADOnet
    {
        private SqlConnection conexion;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private DataSet ds;

        public void InsertarModificarEliminar(List<SqlParameter>parametros, string procedimiento)
        {
            conexion = new SqlConnection(@"data source=PSEHGAFT-PC;initial catalog=LaPape;integrated security=True");
            cmd = new SqlCommand("", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                foreach (SqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public DataSet Consultas(List<SqlParameter> parametros, string procedimiento)
        {
            ds = new DataSet();
            conexion = new SqlConnection(@"data source=PSEHGAFT-PC;initial catalog=LaPape;integrated security=True");
            cmd = new SqlCommand(procedimiento, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                foreach (SqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
    }
}
