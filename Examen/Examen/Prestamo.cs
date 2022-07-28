using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Prestamo
    {
        bool _prestado;
        string _genero;

        public bool Prestado { get => _prestado; set => _prestado = value; }
        public string Genero { get => _genero; set => _genero = value; }

        public Prestamo()
        {
            Prestado = false;
            Genero = "";
        }
        public void entregar()
        {
            Prestado = true;
        }
        public void devolver()
        {
            Prestado = false;
        }
        public bool isEntregado()
        {
            return Prestado;
        }

    }
}
