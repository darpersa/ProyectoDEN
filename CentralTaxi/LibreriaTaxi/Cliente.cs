using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Cliente
    {
        private String _nombre;
        private String _rut;
        private int _telefono;

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        

        public String Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Cliente(String nombre, String rut, int telefono)
        {
            _nombre = nombre;
            _rut = rut;
            _telefono = telefono;
        }
        
    }
}
