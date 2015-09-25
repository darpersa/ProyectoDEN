using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTaxi
{
    public class Taxi
    {
        private String _patente;
        private String _conductor;
        private int _id;
        private List<Viaje> _listViaje;

        public List<Viaje> ListViaje
        {
            get { return _listViaje; }
            set { _listViaje = value; }
        }
        

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public Taxi()
        {
            _listViaje = new List<Viaje>();
        }
    }
}
