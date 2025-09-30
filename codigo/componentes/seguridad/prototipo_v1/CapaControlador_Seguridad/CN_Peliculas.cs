using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad
{
    public class CN_Peliculas
    {
        private string connectionString = "Dsn=segundoparcial2k25";
    }
    public DataTable MostrarPelicula()
    {
        try
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM peliculas";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al cargar peliculas: " + ex.Message);
        }
    }

    
    // MÉTODO INSERTAR EMPLEADO
    public void InsertarPelicula(string nombre, string puesto, string departamento, string usuario)
    {
        try
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES (?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@puesto", puesto);
                    cmd.Parameters.AddWithValue("@departamento", departamento);

                    cmd.ExecuteNonQuery();

                    // Obtener el ID del empleado insertado
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    int codigoEmpleado = Convert.ToInt32(cmd.ExecuteScalar());

                    // Registrar en bitácora
                    string detalles = $"Nuevo empleado: {nombre}, Puesto: {puesto}, Depto: {departamento}";
                    RegistrarBitacora(usuario, "INSERT", codigoEmpleado, detalles);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al insertar empleado: " + ex.Message);
        }
    }

    // MÉTODO EDITAR EMPLEADO
    public void EditarPelicula(string idEmpleado, string nombre, string puesto, string departamento, string usuario)
    {
        try
        {
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE empleados SET nombre_completo = ?, puesto = ?, departamento = ? WHERE codigo_empleado = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@puesto", puesto);
                    cmd.Parameters.AddWithValue("@departamento", departamento);
                    cmd.Parameters.AddWithValue("@id", idEmpleado);

                    cmd.ExecuteNonQuery();

                    // Registrar en bitácora
                    string detalles = $"Empleado actualizado: {nombre}, Puesto: {puesto}, Depto: {departamento}";
                    RegistrarBitacora(usuario, "UPDATE", Convert.ToInt32(idEmpleado), detalles);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al editar empleado: " + ex.Message);
        }
    }

    // MÉTODO ELIMINAR EMPLEADO
    public void EliminarPelicula(string idEmpleado, string usuario)
    {
        try
        {
            // Primero obtener datos del empleado antes de eliminar
            string nombreEmpleado = "";
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                conn.Open();
                string querySelect = "SELECT nombre_completo FROM empleados WHERE codigo_empleado = ?";
                using (OdbcCommand cmd = new OdbcCommand(querySelect, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    nombreEmpleado = cmd.ExecuteScalar()?.ToString();
                }

                // Ahora eliminar
                string queryDelete = "DELETE FROM empleados WHERE codigo_empleado = ?";
                using (OdbcCommand cmd = new OdbcCommand(queryDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    cmd.ExecuteNonQuery();

                    // Registrar en bitácora
                    string detalles = $"Empleado eliminado: {nombreEmpleado}";
                    RegistrarBitacora(usuario, "DELETE", Convert.ToInt32(idEmpleado), detalles);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar empleado: " + ex.Message);
        }
    }
}

