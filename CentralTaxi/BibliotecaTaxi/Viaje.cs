using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTaxi
{
    public class Viaje
    {
        private int _id;
        private String _cliente;
        private String _direccionInicio;
        private String _direccionFinal;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public String DireccionInicio
        {
            get { return _direccionInicio; }
            set { _direccionInicio = value; }
        }

        public String DirecconFinal
        {
            get { return _direccionFinal; }
            set { _direccionFinal = value; }
        }

        
    }
}
