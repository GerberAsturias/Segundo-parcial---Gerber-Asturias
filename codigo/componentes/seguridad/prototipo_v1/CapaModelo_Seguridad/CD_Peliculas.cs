using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad
{
    public class CD_Peliculas
    {
        private Conexion conexion = new Conexion()
            public DataTable MostrarPeliculas()
        {
            DataTable tabla = new DataTable();
            OdbcConnection conn = null;

            try
            {
                conn = conexion.AbrirConexion();
                string consulta = "SELECT codigo_empleado, nombre_completo, puesto, departamento FROM empleados WHERE estado = 1";

                using (OdbcCommand comando = new OdbcCommand(consulta, conn))
                using (OdbcDataAdapter da = new OdbcDataAdapter(comando))
                {
                    da.Fill(tabla);
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar empleados: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conexion.CerrarConexion(conn);
            }

        }
    }
    public void InsertarEmpleado(string nombre, string puesto, string departamento)
    {
        OdbcConnection conn = null;

        try
        {
            conn = conexion.AbrirConexion();
            string consulta = @"INSERT INTO empleados 
                           (nombre_completo, puesto, departamento, estado) 
                           VALUES (?, ?, ?, 1)";

            using (OdbcCommand comando = new OdbcCommand(consulta, conn))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", puesto);
                comando.Parameters.AddWithValue("?", departamento);

                comando.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al insertar empleado: " + ex.Message);
        }
        finally
        {
            if (conn != null)
                conexion.CerrarConexion(conn);
        }
    }
    public void EditarEmpleado(int codigo, string nombre, string puesto, string departamento)
    {
        OdbcConnection conn = null;

        try
        {
            conn = conexion.AbrirConexion();
            string consulta = @"UPDATE empleados 
                               SET nombre_completo = ?, puesto = ?, departamento = ? 
                               WHERE codigo_empleado = ?";

            using (OdbcCommand comando = new OdbcCommand(consulta, conn))
            {
                comando.Parameters.AddWithValue("?", nombre);
                comando.Parameters.AddWithValue("?", puesto);
                comando.Parameters.AddWithValue("?", departamento);
                comando.Parameters.AddWithValue("?", codigo);

                comando.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al editar empleado: " + ex.Message);
        }
        finally
        {
            if (conn != null)
                conexion.CerrarConexion(conn);
        }
    }

    public void EliminarEmpleado(int codigo)
    {
        OdbcConnection conn = null;

        try
        {
            conn = conexion.AbrirConexion();
            string consulta = "DELETE FROM empleados WHERE codigo_empleado = ?";

            using (OdbcCommand comando = new OdbcCommand(consulta, conn))
            {
                comando.Parameters.AddWithValue("?", codigo);

                int resultado = comando.ExecuteNonQuery();
                if (resultado == 0)
                    throw new Exception("No se encontró el empleado para eliminar");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar empleado: " + ex.Message);
        }
        finally
        {
            if (conn != null)
                conexion.CerrarConexion(conn);
        }
    }

}
        


