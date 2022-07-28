using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    class Serie : Prestamo
    {
        string _titulo;
        int _temporadas;
        string _creador;

        public string Titulo { get => _titulo; set => _titulo = value; }
        public int Temporadas { get => _temporadas; set => _temporadas = value; }
        public string Creador { get => _creador; set => _creador = value; }

        public Serie()
        {
            Titulo = "";
            Temporadas = 3;
            Creador = "";
            Prestado = false;
            Genero = "";
        }
        public Serie(string g, string t, int temp, string c)
        {
            Titulo = t;
            Temporadas = temp;
            Creador = c;
            Prestado = false;
            Genero = g;
        }
        public void mostrar()
        {
            MessageBox.Show("Genero"+ Genero+"Titulo"+Titulo+"Creador"+Creador+"Temporadas"+Temporadas);
        }
    }
}
