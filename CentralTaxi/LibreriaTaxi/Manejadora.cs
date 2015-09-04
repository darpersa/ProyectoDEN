using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Manejadora
    {
        private Taxi[] _taxi;

        public Taxi[] Taxi
        {
            get { return _taxi; }
            set { _taxi = value; }
        }

        public Manejadora()
        {
            this.Init();
        }

        public void Init()
        {
            _taxi = new Taxi[0];
        }

        public int existe(int cert)
        {
            for (int i = 0; i < _taxi.Length; i++)
            {
                if (_taxi[i] != null && cert == _taxi[i].Codigo)
                    return i;
            }
            return -1;
        }

        public string AgregarTaxi(Taxi cod)
        {
            if (existe(cod.Codigo) == -1)
            {
                Array.Resize(ref _taxi, _taxi.Length + 1);
                _taxi[Taxi.Length - 1] = cod;
                return "Taxi agregado y tiene un valor de $" + cod.Valor;
            }
            else
                return "Taxi ya emitido";
        }

        public string eliminar(Taxi cod)
        {
            if (existe(cod.Codigo) == -1)
            {
                Array.Resize(ref _taxi, _taxi.Length + 1);
                _taxi[Taxi.Length - 1] = null;
                return "Taxi eliminado";
            }
            else
                return "Taxi no existe";
        }

    }
}
