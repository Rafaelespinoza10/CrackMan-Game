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
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace pacman_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

            // Propiedades de la ventana.
            this.MaximizeBox = false;    // la ventana no podra maximizarse. 
                                         //Icon ic = new Icon(Application.StartupPath + @"../../Assets/icon.png");

            Icon ico = global::pacman_2.Properties.Resources.icon;   // se cambia el icono. 
            this.Icon = ico;

            // Musica de entrada de menu
            using (var sp = new SoundPlayer(@"../../Sounds/Pacman-eats.wav"))
            {
                sp.Play();  // reproduccion del sonido de intro de pacman. 
            }

        }

        private void b_help_Click(object sender, EventArgs e)
        {
            Form Ventana = new Controls();
            Ventana.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           pb_GifMenu.Image = Image.FromFile(@"../../Assets/menu.gif");
           pb_GifMenu.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Start_Player1_Click(object sender, EventArgs e)
        {
            Form ventana = new Form1();     // Llamada al formulario de incio de juego.
            ventana.Show();                 // muestra el incio del juego
            this.Hide();                    // Cierra el menu principal 
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();              // Cierra la aplicacion. 
        }

        private void Start_Player2_Click(object sender, EventArgs e)
        {
            Form ventana = new Multiplayer();   // llamada al formulario de multijugador.
            ventana.Show();                     // Muestra el inicio del juego.
            this.Hide();                         // cierra el menu principal 
        }

        private void b_credits_Click(object sender, EventArgs e)
        {
            Form Ventana = new Creditos();
            Ventana.Show();
            this.Hide();

        }
    }
}
