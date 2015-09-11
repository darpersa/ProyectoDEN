using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Taxi
    {
        private String _patente;
        private String _conductor;
        private List<Viaje> _viaje;
                             
        public String Conductor
        {
            get { return _conductor; }
            set { _conductor = value; }
        }
        
        public String Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }

        public Taxi(String patente, String conductor)
        {
            _patente = patente;
            _conductor = conductor;
            _viaje = new List<Viaje>();
        }

        public int existe(String cod)
        {
            for (int i = 0; i < _viaje.Count(); i++)
            {
                if (_viaje[i] != null && _viaje[i].Codigo.CompareTo(cod) == 0)
                     return i;
            }
                return -1;
        }

        public String agregarViaje(Viaje cod)
        {
            if(existe(cod.Codigo)==-1)
            {
                _viaje.Add(cod);
                return "Viaje agregado";
            }
            return "Viaje ya emitido";
        }
    }
}
