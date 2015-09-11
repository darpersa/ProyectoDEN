using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Manejadora
    {
        private List<Taxi> _taxi;
        private List<Cliente> _cliente;
        private Viaje _viaje;

        public Manejadora(Viaje viaje)
        {
            _taxi = new List<Taxi>();
            _cliente = new List<Cliente>();
            _viaje = viaje;
        }

        public int existe(String cod)
        {
            if (_viaje.Codigo.CompareTo(cod) == 0)
                return 1;
            else
                return -1;
        }

        public String agregar(Viaje cod)
        {
            if (existe(cod.Codigo) == -1)
            {
                _taxi.Add(Viaje);
            }
            else
                return "El viaje no existe";
        }
    }
}
