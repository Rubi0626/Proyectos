using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        Serie x = new Serie();
        Videojuego vj = new Videojuego();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            if (cmbtipo.SelectedItem.ToString() == "Serie")
            {
                Serie temp = new Serie(comboBox2.SelectedItem.ToString());
            }
            else
            {

            }
        }

        private void BtnPrestar_Click(object sender, EventArgs e)
        {
            x.entregar();

        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            x.devolver();

        }

        private void BtnComprobar_Click(object sender, EventArgs e)
        {
            if (Iisentrgado;)
            {

            }
        }
    }
}
