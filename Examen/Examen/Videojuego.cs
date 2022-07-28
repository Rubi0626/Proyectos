using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    class Videojuego : Prestamo
    {
        string _titulo;
        int _horas;
        string _compañia;

        public string Titulo { get => _titulo; set => _titulo = value; }
        public int Horas { get => _horas; set => _horas = value; }
        public string Compañia { get => _compañia; set => _compañia = value; }

        public Videojuego()
        {
            Prestado = false;
            Genero = "";
            Titulo = "";
            Horas = 10;
            Compañia = "";
        }
        public Videojuego(string g, string t, string c, int h)
        {
            Prestado = false;
            Genero = g;
            Titulo = t;
            Horas = h;
            Compañia = c;
        }
        public void mostrar()
        {
            MessageBox.Show("Genero" + Genero + "Titulo" + Titulo +"Horas"+Horas+"Compañia"+Compañia);
        }
    }
}
