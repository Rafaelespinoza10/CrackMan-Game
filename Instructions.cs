using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pacman_2
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            // Propiedades de la ventana.
            this.MaximizeBox = false;    // la ventana no podra maximizarse. 
                                         //Icon ic = new Icon(Application.StartupPath + @"../../Assets/icon.png");

            Icon ico = global::pacman_2.Properties.Resources.icon;   // se cambia el icono. 
            this.Icon = ico;

            // Musica de entrada de menu
            using (var sp = new SoundPlayer(@"../../Sounds/Musica.wav"))
            {
                sp.Play();  // reproduccion del sonido de intro de pacman. 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Ventana = new Controls();
            Ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Ventana = new Gameplay();
            Ventana.Show();
            this.Hide();

        }
    }
}
