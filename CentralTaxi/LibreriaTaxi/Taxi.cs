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
        private Viaje[] _viaje;

        public Viaje[] Viaje
        {
            get { return _viaje; }
            set { _viaje = value; }
        }
        

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
            _viaje = new Viaje[0];
        }

      
    }
}
