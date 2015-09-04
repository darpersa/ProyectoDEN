using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Viaje
    {
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
     

        public Taxi(Cliente cliente, int valor, int cod)
        {
            _cliente = cliente;
            _valor = valor;
            _codigo = cod;
        }
    }
}
