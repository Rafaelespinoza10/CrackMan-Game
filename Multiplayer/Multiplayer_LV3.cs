﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Media;
using System.Threading;

namespace pacman_2
{
    public partial class Multiplayer_LV3 : Form
       
    
    {
        // atributos
        private bool goup, godown, goleft, goright, IsGameOver = false;   //direcciones del jugador 1
        private bool goup2, godown2, goleft2, goright2;                   // direcciones del jugador 2 
        private int score, playerSpeed;                            // velocidad y puntaje del jugador 1
        private int score2, playerSpeed2;                          // velocidad y puntaje del jugador 2
        private int EnemigosSpeed ;                               //velocidad del enemigo 
        private int checkSpeed = 5;
        private int lifes;                                         // vidas del jugador 1
        private int lifes2;                                        // vidas del jugador 2
        
        //dirrecion de enemigos 
        private List<Result> dirs =  new List<Result>();     /// lista de resultdos de posicion
    


        private List<Label> Walls = new List<Label>();        // dibujamos el mapa, para ello se hace una lista de paredes
        private List<PictureBox> Enemigos = new List<PictureBox>(); // dibujamos los enemigos, se hace una lista de enemigos. 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Enemigo_Tick(object sender, EventArgs e)   
        {
           await EnemigoMov();
        }

        private void MovimientoEne_Tick(object sender, EventArgs e)
        {
            test();
        }

        public Multiplayer_LV3()
        {
            InitializeComponent();
           
            // Propiedades de la ventana.
            this.MaximizeBox = false;    // la ventana no podra maximizarse. 
                                         //Icon ic = new Icon(Application.StartupPath + @"../../Assets/icon.png");

            this.lifes = 3;
            this.lifes2 = 3;
            Icon ico = global::pacman_2.Properties.Resources.icon;   // se cambia el icono. 
            this.Icon = ico;                                         // icono de pacman 

            // paredes del  juego
            Walls.Add(label1);
            Walls.Add(label2);
            Walls.Add(label3);
            Walls.Add(label4);
            Walls.Add(label5);
            Walls.Add(label6);
            Walls.Add(label7);
            Walls.Add(label8);
            Walls.Add(label9);
            Walls.Add(label10);
            Walls.Add(label11);
            Walls.Add(label12);
            Walls.Add(label13);
            Walls.Add(label14);
            Walls.Add(label15);
            Walls.Add(label16);
            Walls.Add(label17);
            Walls.Add(label18);
            Walls.Add(label19);
            Walls.Add(label20);
            Walls.Add(label21);
            Walls.Add(label22);
            Walls.Add(label23);
            Walls.Add(label24);
            Walls.Add(label25);
            Walls.Add(label26);
            Walls.Add(label27);
            Walls.Add(label28);
            Walls.Add(label29);
            Walls.Add(label30);
            Walls.Add(label31);
            Walls.Add(label32);
            Walls.Add(label33);
            Walls.Add(label34);
            Walls.Add(label35);
            Walls.Add(label36);
            Walls.Add(label37);
            Walls.Add(label38);
            Walls.Add(label39);
            Walls.Add(label40);
            Walls.Add(label41);
            Walls.Add(label42);
            Walls.Add(label43);
            Walls.Add(label44);
            Walls.Add(label45);
            Walls.Add(label46);
            Walls.Add(label47);
            Walls.Add(label48);
            Walls.Add(label49);
            Walls.Add(label50);
            Walls.Add(label51);
            Walls.Add(label52);
            Walls.Add(label53);
            Walls.Add(label54);
            Walls.Add(label55);

            // se anaden las cuatro direcciones de los enemigos. 
            dirs.Add(new Result(false, false));
            dirs.Add(new Result(false, false));
            dirs.Add(new Result(false, false));
            dirs.Add(new Result(false, false));
            dirs.Add((new Result(false, false)));
            // se agregan los enemigos del juego.
            Enemigos.Add(pb_orange);       
            Enemigos.Add(pb_pink);
            Enemigos.Add(pb_red);
            Enemigos.Add(pb_blue);
            Enemigos.Add(pb_blue2);

            //iniciamos el juego
            Start();

            // Musica de fondo del juego

            if (IsGameOver == false)
            {
                using (var sp = new SoundPlayer(@"../../Sounds/Intro.wav"))
                {
                    sp.Play();  // reproduccion del sonido de intro de pacman. 
                }

            }

          
        }


        // ------------------------------------- COLISIONES DE LOS JUGADORES ---------------------------------------------
        private bool Colision(PictureBox Player, bool goleft, bool goright ,  bool goup, bool godown)
        {
            bool colision = false;
            int h = Player.Width  ;
            int w = Player.Height  ;
            int x = Player.Location.X;
            int y = Player.Location.Y ;

            if (goleft)
            {
                x = Player.Location.X  - checkSpeed;
            }

            if (goright)
            {
                x = Player.Location.X + checkSpeed;
            }

            if (goup)
            {
                y = Player.Location.Y - checkSpeed;
            }

            if (godown)
            {
                y =  Player.Location.Y + checkSpeed;
            }


            Rectangle Contaniner = new Rectangle(x,y,h,w);
            
            foreach( Label l in Walls)
            {
                if (l.Bounds.IntersectsWith(Contaniner))
                {
                    colision = true;
                    playerSpeed = 0;
                    break;
                }
                else
                {
                    playerSpeed = 11;
                }
            }

            return colision;
        }

     
        //------------------------ CONTROLES ---------------------------------------------------------------------
        private void keyisdown(object sender, KeyEventArgs e)
        {

            //---------------------------- PRIMER JUGADOR -------------------------------------------------------
            if(e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            //------------------------------------------ SEGUNDO JUGADOR -------------------------------------------

            if (e.KeyCode == Keys.W)
            {
                goup2 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godown2 = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft2 = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright2 = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //-====================================== PRIMER JUGADOR ==============================================
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            //======================================== SEGUNDO JUGADOR =============================================

            if (e.KeyCode == Keys.W)
            {
                goup2 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown2 = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft2 = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright2 = false;
            }

        }

        //  -------------------------------- TIMER 1; INICIO DEL JUEGO -------------------------------------------------

        private void mainGameTimer(object sender, EventArgs e)
        {
            lb_score.Text = "SCORE: " + score;
            lb_score2.Text = "SCORE: " + score2;


            //------------------------------------------- PRIMER JUGADOR -----------------------------------------------
            if (goleft == true)
            { 
                pb_pacman.Image = Properties.Resources.left;
                Colision(pb_pacman, goleft, goright, goup,godown);
                pb_pacman.Left -= playerSpeed;

            }
            if(goright == true)
            {
                pb_pacman.Image = Properties.Resources.right;
                Colision(pb_pacman,goleft, goright, goup, godown);
                pb_pacman.Left += playerSpeed;
            }
            if(godown == true)
            {
                pb_pacman.Image = Properties.Resources.down;
                Colision(pb_pacman, goleft, goright, goup, godown);
                pb_pacman.Top += playerSpeed;
            }
            if(goup == true)
            {
                pb_pacman.Image = Properties.Resources.Up;
                Colision(pb_pacman, goleft, goright, goup, godown);
                pb_pacman.Top -= playerSpeed;
            }

            if(pb_pacman.Left < 123)
            {
                pb_pacman.Left = 583;
            }
            if(pb_pacman.Left > 583)
            {
                pb_pacman.Left = 130;
            }

            //============================================ SEGUNDO JUGADOR =============================================

            if (goleft2 == true)
            {
                player2.Image = Properties.Resources.paclft;
                Colision(player2, goleft2, goright2, goup2, godown2);
                player2.Left -= playerSpeed;

            }
            if (goright2 == true)
            {
                player2.Image = Properties.Resources.pacrg;
                Colision(player2, goleft2, goright2, goup2, godown2);
                player2.Left += playerSpeed;
            }
            if (godown2 == true)
            {
                player2.Image = Properties.Resources.pacdown;
                Colision(player2, goleft2, goright2, goup2, godown2);
                player2.Top += playerSpeed;
            }
            if (goup2 == true)
            {
                player2.Image = Properties.Resources.pacup;
                Colision(player2, goleft2, goright2, goup2, godown2);
                player2.Top -= playerSpeed;
            }

            if (player2.Left < 123)
            {
                player2.Left = 583;
            }
            if (player2.Left > 583)
            {
                player2.Left = 130;
            }

            ReLocateEnmigos();


            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "coin")
                {
                   
                        if (((PictureBox)x).Bounds.IntersectsWith(pb_pacman.Bounds))
                        {
                        using (var sp = new SoundPlayer(@"../../Sounds/Pacman-eats.wav"))
                        {
                            sp.Play();  // reproduccion del sonido de intro de pacman. 
                        }
                        this.Controls.Remove(x);
                            score =  score +10;
                        Win();
                    }

                         if (((PictureBox)x).Bounds.IntersectsWith(player2.Bounds))
                        {
                        using (var sp = new SoundPlayer(@"../../Sounds/Pacman-eats.wav"))
                        {
                            sp.Play();  // reproduccion del sonido de intro de pacman. 
                        }
                            this.Controls.Remove(x);
                            score2 = score2 + 10;
                        Win();
                    }

                }

            }

            foreach( PictureBox enemigo in Enemigos )
            {
                if (enemigo.Bounds.IntersectsWith(pb_pacman.Bounds)){
                    lifes--;
                    using (var sp = new SoundPlayer(@"../../Sounds/pacman-dies.wav"))
                    {
                        sp.Play();  // reproduccion del sonido de intro de pacman. 
                    }
                    resetGame(pb_pacman);
                }

                if (enemigo.Bounds.IntersectsWith(player2.Bounds))
                {
                    lifes2--;
                    using (var sp = new SoundPlayer(@"../../Sounds/pacman-dies.wav"))
                    {
                        sp.Play();  // reproduccion del sonido de intro de pacman. 
                    }
                    resetGame(player2);

                }


            }

           

        }

        //------------------------------------------ INCIO DEL JUEGO------------------------------------------------
         
        private void Start()
        {
            lb_score2.Text = "SCORE = 0";       //  el puntaje del segundo jugador es cero. 
            pb_pacman.Location = new Point(532, 454);  //posicion  inicial del primer player.
            score = 0;    // el puntaje del jugador 1 es cero


            lb_score.Text = "SCORE: 0";         // el puntaje del primer jugador es cero.
            player2.Location = new Point(147, 26);  // posicion inicial del segundo player
            score2 = 0;                    // el puntaje del jugador 2 es cero

            playerSpeed = 10;               // velocidad del jugador. 
            playerSpeed2 = 10;
            DrawingLifes();


            IsGameOver = false;
            gameOver();

        }

        private void resetGame(PictureBox player)
        {
            
            if(player.Name == "pb_pacman")
            {
                 pb_pacman.Location = new Point(532, 454);  //posicion  inicial del primer player.    
            }
            else if(player.Name == "player2")
            {
                player2.Location = new Point(147, 26);  // posicion inicial del segundo player
            }

            if (lifes <= 0) this.Controls.Remove(pb_pacman);               // velocidad del jugador. 
            if (lifes2 <= 0) this.Controls.Remove(player2);               // velocidad del jugador. 
        

            DrawingLifes();
            IsGameOver = false;
            gameOver();
            
           
           
        }

        //-------------------------------------- DIRECCION DEL MOVIMIENTO DE LOS FANTASMAS-----------------------------
        
        private async Task EnemigoMov()
        {
            int i = 0;
           foreach(PictureBox enenigo in Enemigos)
            {
                //incio de movimiento de los enemigos
                bool dir = new Random().Next(2) == 1;
                bool delta  = new Random().Next(2) == 1;
                
                

                if ( i < dirs.Count)
                {
                    dirs[i].Dir = dir;
                    dirs[i].Delta = delta;
                }

                i++;
            }
            
        }

        //=======================================  COLISIONES DE LOS FANTASMAS ====================================
        private Result EnemigosColisiones(PictureBox Enemigo, bool dir, bool delta)
        {
            Result colision = new Result(dir ,  delta);
            int h = Enemigo.Width;
            int w = Enemigo.Height;
            int x = Enemigo.Location.X;
            int y = Enemigo.Location.Y;
            checkSpeed = 12;

            if(dir == true && delta == true)
            {
                x = Enemigo.Location.X - checkSpeed;
            }

            if(dir == true && delta == false)
            {
                x = Enemigo.Location.X + checkSpeed;
            }

            if (dir == false && delta == true)
            {
                y = Enemigo.Location.Y + checkSpeed;
            }

            if (dir == false && delta == false)
            {
                y = Enemigo.Location.Y - checkSpeed;
            }
           

            Rectangle Contaniner = new Rectangle(x, y, h, w);

            foreach (Label l in Walls)
            {
                if (l.Bounds.IntersectsWith(Contaniner))
                {
                    colision.Dir = !dir ;
                    colision.Delta = !delta;
                    EnemigosSpeed = 0;
                    break;
                }
               
            }

            return colision;
        }
        
        private void test()
        {
            for(int i=0; i < dirs.Count; i++)
            {
                PictureBox ene = Enemigos[i];
                Result mov = dirs[i];
                EnemigosSpeed = 15;
                if (dirs[i].Dir == true && dirs[i].Delta == true)
                 {
                    EnemigosColisiones(ene, mov.Dir, mov.Delta);
                    mov.Dir = EnemigosColisiones(ene, mov.Dir, mov.Delta).Dir;
                    mov.Delta = EnemigosColisiones(ene, mov.Dir, mov.Delta).Delta;
                    Enemigos[i].Left -= EnemigosSpeed;
                 }

                if(dirs[i].Dir == true && dirs[i].Delta == false)
                {
                    EnemigosColisiones(ene, mov.Dir, mov.Delta);
                    mov.Dir = EnemigosColisiones(ene, mov.Dir, mov.Delta).Dir;
                    mov.Delta = EnemigosColisiones(ene, mov.Dir, mov.Delta).Delta;
                    Enemigos[i].Left += EnemigosSpeed;

                }

                if (dirs[i].Dir == false && dirs[i].Delta == true)
                {
                    EnemigosColisiones(ene, mov.Dir, mov.Delta);
                    mov.Dir = EnemigosColisiones(ene, mov.Dir, mov.Delta).Dir;
                    mov.Delta = EnemigosColisiones(ene, mov.Dir, mov.Delta).Delta;
                    Enemigos[i].Top += EnemigosSpeed;
                }

                if (dirs[i].Dir == false && dirs[i].Delta == false)
                {
                    mov.Dir   = EnemigosColisiones(ene, mov.Dir, mov.Delta).Dir;
                    mov.Delta = EnemigosColisiones(ene, mov.Dir, mov.Delta).Delta;
                    Enemigos[i].Top -= EnemigosSpeed;
                }
            }
        }

        private void DrawingLifes()
        {
            CountainerLifes2.Controls.Clear();
            ContainerLifes.Controls.Clear();

            for(int i = 0; i < lifes; i++)
            {
                PictureBox life = new PictureBox();
                life.Image = Image.FromFile(@"../../Assets/Lifes.png");
                life.Size = new Size(17, 30);
                life.BackColor = Color.Transparent;
                life.SizeMode =  PictureBoxSizeMode.StretchImage;
                ContainerLifes.Controls.Add(life);
            }

            
            for (int i = 0; i < lifes2; i++)
            {
                PictureBox life = new PictureBox();
                life.Image = Image.FromFile(@"../../Assets/Lifes.png");
                life.Size = new Size(17, 30);
                life.BackColor = Color.Transparent;
                life.SizeMode = PictureBoxSizeMode.StretchImage;
                CountainerLifes2.Controls.Add(life);
            }

        }

        private void ReLocateEnmigos()
        {
            foreach(PictureBox x in Enemigos)
            {
                if (x.Left < 123)
                {
                    x.Left = 583;
                }
                if (x.Left > 583)
                {
                    x.Left = 130;
                }

            }
        }

        private void gameOver()
        {
             if(lifes <= 0 && lifes2 <= 0 )
            {
                IsGameOver = true;
                lb_GameOver.Enabled = true;
                gametmr.Stop();
                DirEnemigo.Stop();
                MovimientoEne.Stop();
                Thread.Sleep(500);
                Form ventana = new Form2();   // de regreso al menu principal
                ventana.Show();
                this.Hide();
            }
            else{ 
                gametmr.Start();
                DirEnemigo.Start();
                MovimientoEne.Start();

            }
        }
        private void Win()
        {
            if((score + score2) >= 770)
            {
                lb_win.Enabled = true;
                gametmr.Stop();
                DirEnemigo.Stop();
                MovimientoEne.Stop();
                Thread.Sleep(500);
                Form ventana = new Form2();   // de regreso al menu principal
                ventana.Show();
                this.Hide();
            }
        }
    }
}