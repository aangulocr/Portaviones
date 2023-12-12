using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WEB_REST.Models;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Runtime.InteropServices;

namespace WEB_REST.DB_DATA
{
    public class IngresoAviones
    {
        public static bool InsertarAvion(Ingreso _ingreso)
        {
            using(SqlConnection conn = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("InsertarAvion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serie", _ingreso.Serie);
                cmd.Parameters.AddWithValue("@Marca", _ingreso.Marca);
                cmd.Parameters.AddWithValue("@Modelo", _ingreso.Modelo);
                cmd.Parameters.AddWithValue("@NombreFantasia", _ingreso.NombreFantasia);
                cmd.Parameters.AddWithValue("@DimensionAla", _ingreso.DimensionAla);
                cmd.Parameters.AddWithValue("@Alto", _ingreso.Alto);
                cmd.Parameters.AddWithValue("@Largo", _ingreso.Largo);
                cmd.Parameters.AddWithValue("@DistanciaVuelo", _ingreso.DistanciaVuelo);
                cmd.Parameters.AddWithValue("@Tecnico", _ingreso.Tecnico);
                cmd.Parameters.AddWithValue("@Activo", _ingreso.Activo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }catch(Exception ex) { return false; }

            }
        }
        
        public static List<Ingreso> Listar()
        {
            //List<Ingreso> _ListaIngreso = new List<Ingreso>();
            //using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            //{
            //    SqlCommand cmd = new SqlCommand("sp_listar", conexion);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    try
            //    {

            //    }catch(Exception ex)
            //    {

            //    }
            //}
            return null;
        }
    }
}