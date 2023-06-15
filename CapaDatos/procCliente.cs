using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class procCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly procCliente _instancia = new procCliente();
        //privado para evitar la instanciación directa
        public static procCliente Instancia
        {
            get
            {
                return procCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.edad = Convert.ToInt32(dr["edad"]);
                    Cli.telefono = Convert.ToInt32(dr["telefono"] is DBNull ? 0 : dr["telefono"]);
                    Cli.email = dr["email"].ToString();
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        /////////////////////////InsertaCliente
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@edad", Cli.edad);
                cmd.Parameters.AddWithValue("@telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@email", Cli.email);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        ////////////////////listado de Empresa
        public List<entEmpresa> ListaEmpresa()
        {
            SqlCommand cmd = null;
            List<entEmpresa> lista = new List<entEmpresa>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaEmpresa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    entEmpresa emp = new entEmpresa();
                    emp.idEmpresa = Convert.ToInt32(dr["idEmpresa"]); ;
                    emp.nombre = dr["nombre"].ToString();
                    emp.direccion = dr["direccion"].ToString();
                    emp.telefono = Convert.ToInt32(dr["telefono"]);
          
                    lista.Add(emp);
                    
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        ////////////////////listado de Origen
        public List<entOrigen> ListarOrigen()
        {
            SqlCommand cmd = null;
            List<entOrigen> lista = new List<entOrigen>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaOrigen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrigen Origen = new entOrigen();
                    Origen.idOrigen = Convert.ToInt32(dr["idOrigen"]);
                    Origen.ciudadOrigen = dr["ciudadOrigen"].ToString();
                    Origen.codCiudadOrigen = dr["codCiudad"].ToString();
                    lista.Add(Origen);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        ////////////////////listado de Destino
        public List<entDestino> ListarDestino()
        {
            SqlCommand cmd = null;
            List<entDestino> lista = new List<entDestino>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaDestino", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDestino Destino = new entDestino();
                    Destino.idDestino = Convert.ToInt32(dr["idDestino"]);
                    Destino.ciudadDestino = dr["ciudadDestino"].ToString();
                    Destino.codCiudadDestino = dr["codCiudad"].ToString();
                    lista.Add(Destino);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        ////////////////////listado de Itinerario
        public List<entItinerario> ListaItinerario()
        {
            SqlCommand cmd = null;
            List<entItinerario> lista = new List<entItinerario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaItinerario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
           
                while (dr.Read())
                {
                    entItinerario Itinerario = new entItinerario();
                    Itinerario.idItinerario = Convert.ToInt32(dr["idItinerario"]);
                    Itinerario.hora = Convert.ToDateTime(dr["hora"]);
                    Itinerario.fecha = Convert.ToDateTime(dr["fecha"]);
                    Itinerario.idOrigen = Convert.ToInt32(dr["idOrigen"]);
                    Itinerario.idDestino = Convert.ToInt32(dr["idDestino"]);
                    lista.Add(Itinerario);
                 
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //Listado de Itinerarios por filtro
        public List<entItinerario> ListaItinerarioFiltrado(int idOrigen, int idDestino)
        {
            SqlCommand cmd = null;
            List<entItinerario> lista = new List<entItinerario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaItinerarioFiltrado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                cmd.Parameters.AddWithValue("@idOrigen", idOrigen);
                cmd.Parameters.AddWithValue("@idDestino", idDestino);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
    
                while (dr.Read())
                {
                    entItinerario Itinerario = new entItinerario();
                    Itinerario.idItinerario = Convert.ToInt32(dr["idItinerario"]);
                    Itinerario.hora = Convert.ToDateTime(dr["hora"]);
                    Itinerario.fecha = Convert.ToDateTime(dr["fecha"]);
                    Itinerario.idOrigen = Convert.ToInt32(dr["idOrigen"]);
                    Itinerario.idDestino = Convert.ToInt32(dr["idDestino"]);
                    lista.Add(Itinerario);
                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return lista;
        }


        ////////////////////listado de Viaje
        public List<entViaje> ListaViaje()
        {
            SqlCommand cmd = null;
            List<entViaje> lista = new List<entViaje>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaViaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 1;
                while (dr.Read())
                {
                    entViaje viaje = new entViaje();
                    viaje.idViaje = Convert.ToInt32(dr["idViaje"]); ;
                    viaje.capacidad = Convert.ToInt32(dr["capacidad"]);
                    viaje.idEmpresa = Convert.ToInt32(dr["idEmpresa"]);
                    viaje.idItinerario = Convert.ToInt32(dr["idItinerario"]);
                    lista.Add(viaje);
                    i++;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        ////////////////////listado de Viaje Filtrado
        public List<entViaje> ListaViajeFiltrado(int idItinerario)
        {
            SqlCommand cmd = null;
            List<entViaje> lista = new List<entViaje>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaViajeFiltrado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                cmd.Parameters.AddWithValue("@idItineario", idItinerario);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entViaje viaje = new entViaje();
                    viaje.idViaje = Convert.ToInt32(dr["idViaje"]);
                    viaje.capacidad = Convert.ToInt32(dr["capacidad"]);
                    viaje.idEmpresa = Convert.ToInt32(dr["idEmpresa"]);
                    viaje.idItinerario = Convert.ToInt32(dr["idItinerario"]);
                    lista.Add(viaje);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return lista;
        }



        ////////////////////listado de Pasaje
        public List<entPasaje> ListaPasaje()
        {
            SqlCommand cmd = null;
            List<entPasaje> lista = new List<entPasaje>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaPasaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
              
                while (dr.Read())
                {
                    entPasaje pasaje = new entPasaje();
                    pasaje.idPasasje = Convert.ToInt32(dr["idPasaje"]); ;
                    pasaje.tipoPasaje = dr["tipoPasaje"].ToString();
                    pasaje.asiento = dr["asiento"].ToString();
                    pasaje.valor = Convert.ToInt32(dr["valor"]);
                    pasaje.idCliente = Convert.ToInt32(dr["idCliente"]);
                    pasaje.idViaje = Convert.ToInt32(dr["idViaje"]);
                    lista.Add(pasaje);
                   
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        #endregion

    }
}
