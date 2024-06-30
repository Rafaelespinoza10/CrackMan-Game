using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace pacman_2
{
    internal class Wall : UserControl
    {
        //field
        private Color backColor = Color.Transparent;

        private Label wall;

        //contructor
        public Wall()
        {
            this.wall = new Label();
            this.wall.AutoSize = false;
            this.wall.TextAlign = ContentAlignment.MiddleCenter;
            this.wall.Tag = "wall";

            this.ResumeLayout();
            this.BackColor = backColor;
            this.Controls.Add(wall);
        }


        public void setWallType()
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Wall
            // 
            this.Name = "Wall";
            this.Load += new System.EventHandler(this.Wall_Load);
            this.ResumeLayout(false);

        }

        private void Wall_Load(object sender, EventArgs e)
        {

        }
    }
}
