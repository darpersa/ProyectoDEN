using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaxi
{
    class Manejadora
    {
        private Viaje[] _viaje;

        public Viaje[] Viaje
        {
            get { return _viaje; }
            set { _viaje = value; }
        }

        public Manejadora()
        {
            this.Init();
        }

        public void Init()
        {
            _viaje = new Viaje[0];
        }

        public int existe(int cert)
        {
            for (int i = 0; i < _viaje.Length; i++)
            {
                if (_viaje[i] != null && cert == _viaje[i].Codigo)
                    return i;
            }
            return -1;
        }

        public string AgregarViaje(Viaje cod)
        {
            if (existe(cod.Codigo) == -1)
            {
                Array.Resize(ref _viaje, _viaje.Length + 1);
                _viaje[Viaje.Length - 1] = cod;
                return "Viaje agregado y tiene un valor de $" + cod.Valor;
            }
            else
                return "Viaje ya emitido";
        }

        public string eliminar(Viaje cod)
        {
            if (existe(cod.Codigo) == -1)
            {
                Array.Resize(ref _viaje, _viaje.Length + 1);
                _viaje[Viaje.Length - 1] = null;
                return "Viaje eliminado";
            }
            else
                return "Viaje no existe";
        }

    }
}
