using Portaviones.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portaviones.Controllers
{
    public class HomeController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        private static List<Ingreso> _objIngreso = new List<Ingreso>();

        private static List<Ingreso> ingresoList = new List<Ingreso>();
        private static List<Retiro> retiroList = new List<Retiro>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ingreso()
        {
            ingresoList.Clear();
            ViewBag.Lista = null;

            return View();
        }

        [HttpPost]
        public ActionResult Ingreso(Ingreso _ingreso) 
        {
            
            if(!ModelState.IsValid)
            {
                ViewBag.Error = "Debe Completar todos los Campos...";
                return View();
            }          

            ingresoList.Add(_ingreso);
            ViewBag.Lista = ingresoList;

            //ViewBag.Lista = ListaIngreso;
            ModelState.Clear();

            return View();
        }


        public ActionResult Retiro()
        {
            retiroList.Clear();
            ViewBag.Registro = null;

            return View();
        }

        [HttpPost]
        public ActionResult Retiro(int? serie, FormCollection form)
        {
            Retiro retiro = new Retiro();
            string boton = form["Buscar"] ?? form["Agregar"];

            if(boton == "Buscar")
            {
                @ViewBag.Boton = "Buscar";
            }else if (boton == "Agregar")
            {
                @ViewBag.Boton = "Agregar";
                @ViewBag.Serie = form["Serie"].ToString();
                @ViewBag.Marca = form["Marca"];
                @ViewBag.Modelo = form["Modelo"];
                @ViewBag.NombreFantasia = form["NombreFantasia"];
                @ViewBag.Detalle = form["Detalle"];
                @ViewBag.Tecnico = form["Tecnico"];
                
                retiro.Serie = @ViewBag.Serie;
                retiro.Marca = @ViewBag.Marca;
                retiro.Modelo = @ViewBag.Modelo;
                retiro.NombreFantasia = @ViewBag.NombreFantasia;
                retiro.Detalle = @ViewBag.Detalle;
                retiro.Tecnico = @ViewBag.Tecnico;
                retiroList.Add(retiro);

                @ViewBag.Registro = retiroList;
                form["Serie"] = "";
                form["Marca"] = "";
                form["Modelo"] = "";
                form["NombreFantasia"] = "";
                form["Detalle"] = "";
                form["Tecnico"] = "";

                return View();
            }

            //if (serie.Equals(0) || !serie.HasValue)
            //{
            //    return View();
            //}

            //llamar a StoreProcedure para retornar la serie buscada

            

            retiro.Serie = serie.Value.ToString();
            retiro.Marca = "Hornet";
            retiro.Modelo = "F18 Hornet";
            retiro.NombreFantasia = "Super Hornet";

            @ViewBag.Serie = retiro.Serie;
            @ViewBag.Marca = retiro.Marca;
            @ViewBag.Modelo = retiro.Modelo;
            @ViewBag.NombreFantasia = retiro.NombreFantasia;

            //retiroList.Add(retiro);
           

            @ViewBag.Registro = retiroList;
            
            //ModelState.Clear();

            return View();
        }

        public ActionResult ListarAviones()
        {
            _objIngreso = new List<Ingreso>();
            try
            {
                using (SqlConnection objCon = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("ListarAviones", objCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ingreso nuevoIngreso = new Ingreso();
                                                        
                            nuevoIngreso.Marca  = reader["Marca"].ToString().ToUpper();
                            nuevoIngreso.Modelo = reader["Modelo"].ToString().ToUpper();

                            nuevoIngreso.NombreFantasia = reader["NombreFantasia"].ToString().ToUpper();
                            nuevoIngreso.Fecha = (DateTime)reader["Fecha"];
                            nuevoIngreso.Tecnico = reader["Tecnico"].ToString().ToUpper();                           
                            
                            _objIngreso.Add(nuevoIngreso);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            return View(_objIngreso);

        }
        
        public ActionResult DespegueAterrizaje() 
        { 
            return View();
        }

        public ActionResult Despegue()
        {
            return View();
        }

        public ActionResult Aterrizaje()
        {
            return View();
        }
    }
}