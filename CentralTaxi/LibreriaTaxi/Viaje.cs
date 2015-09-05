using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Viaje
    {
        private Taxi _taxi;
        private Cliente _cliente;
        private int _valor;
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        

        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        

        public Taxi Taxi
        {
            get { return _taxi; }
            set { _taxi = value; }
        }

        public Viaje(Taxi taxi, Cliente cliente, int valor, int cod)
        {
            _taxi = taxi;
            _cliente = cliente;
            _valor = valor;
            _codigo = cod;
        }
    }
}
