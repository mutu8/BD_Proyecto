using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> ListarCliente()
        {
            return procCliente.Instancia.ListarCliente();
        }

        public void InsertaCliente(entCliente Cli)
        {
            procCliente.Instancia.InsertarCliente(Cli);
        }


        public List<entOrigen> listaOrigen()
        {
            return procCliente.Instancia.ListarOrigen();
        }

        public List<entDestino> listaDestino()
        {
            return procCliente.Instancia.ListarDestino();
        }
        public List<entItinerario> listaItinerario()
        {
            return procCliente.Instancia.ListaItinerario();
        }
        public List<entItinerario> listaItinerarioFiltrado(int idOrigen, int idDestino)
        {
            return procCliente.Instancia.ListaItinerarioFiltrado(idOrigen,idDestino);
        }
        public List<entEmpresa> listaEmpresa()
        {
            return procCliente.Instancia.ListaEmpresa();
        }
       
        public List<entViaje> listaViaje()
        {
            return procCliente.Instancia.ListaViaje();
        }
        public List<entViaje> listaViajeFiltrado(int idItinerario)
        {
            return procCliente.Instancia.ListaViajeFiltrado(idItinerario);
        }
        public List<entPasaje> listaPasaje()
        {
            return procCliente.Instancia.ListaPasaje();
        }
        #endregion

    }
}
