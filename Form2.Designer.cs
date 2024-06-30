namespace pacman_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Start_Player1 = new System.Windows.Forms.Button();
            this.Start_Player2 = new System.Windows.Forms.Button();
            this.b_credits = new System.Windows.Forms.Button();
            this.b_help = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.pb_GifMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GifMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Player1
            // 
            this.Start_Player1.BackColor = System.Drawing.Color.Black;
            this.Start_Player1.FlatAppearance.BorderSize = 0;
            this.Start_Player1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Player1.Font = new System.Drawing.Font("Pixel Tandy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Player1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start_Player1.Location = new System.Drawing.Point(335, 201);
            this.Start_Player1.Name = "Start_Player1";
            this.Start_Player1.Size = new System.Drawing.Size(176, 47);
            this.Start_Player1.TabIndex = 1;
            this.Start_Player1.Text = "PLAYER 1";
            this.Start_Player1.UseVisualStyleBackColor = false;
            this.Start_Player1.Click += new System.EventHandler(this.Start_Player1_Click);
            // 
            // Start_Player2
            // 
            this.Start_Player2.BackColor = System.Drawing.Color.Black;
            this.Start_Player2.FlatAppearance.BorderSize = 0;
            this.Start_Player2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Player2.Font = new System.Drawing.Font("Pixel Tandy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Player2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start_Player2.Location = new System.Drawing.Point(335, 245);
            this.Start_Player2.Name = "Start_Player2";
            this.Start_Player2.Size = new System.Drawing.Size(176, 47);
            this.Start_Player2.TabIndex = 2;
            this.Start_Player2.Text = "PLAYER 2";
            this.Start_Player2.UseVisualStyleBackColor = false;
            this.Start_Player2.Click += new System.EventHandler(this.Start_Player2_Click);
            // 
            // b_credits
            // 
            this.b_credits.BackColor = System.Drawing.Color.Black;
            this.b_credits.FlatAppearance.BorderSize = 0;
            this.b_credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_credits.Font = new System.Drawing.Font("Pixel Tandy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_credits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_credits.Location = new System.Drawing.Point(335, 342);
            this.b_credits.Name = "b_credits";
            this.b_credits.Size = new System.Drawing.Size(176, 47);
            this.b_credits.TabIndex = 3;
            this.b_credits.Text = "CREDITS";
            this.b_credits.UseVisualStyleBackColor = false;
            this.b_credits.Click += new System.EventHandler(this.b_credits_Click);
            // 
            // b_help
            // 
            this.b_help.BackColor = System.Drawing.Color.Black;
            this.b_help.FlatAppearance.BorderSize = 0;
            this.b_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_help.Font = new System.Drawing.Font("Pixel Tandy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_help.Location = new System.Drawing.Point(267, 298);
            this.b_help.Name = "b_help";
            this.b_help.Size = new System.Drawing.Size(325, 47);
            this.b_help.TabIndex = 4;
            this.b_help.Text = "HELP AND CONTROLS";
            this.b_help.UseVisualStyleBackColor = false;
            this.b_help.Click += new System.EventHandler(this.b_help_Click);
            // 
            // b_salir
            // 
            this.b_salir.BackColor = System.Drawing.Color.Black;
            this.b_salir.FlatAppearance.BorderSize = 0;
            this.b_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_salir.Font = new System.Drawing.Font("Pixel Tandy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_salir.Location = new System.Drawing.Point(335, 385);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(176, 47);
            this.b_salir.TabIndex = 5;
            this.b_salir.Text = "EXIT GAME";
            this.b_salir.UseVisualStyleBackColor = false;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // pb_GifMenu
            // 
            this.pb_GifMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_GifMenu.Image = global::pacman_2.Properties.Resources.menu;
            this.pb_GifMenu.Location = new System.Drawing.Point(136, 96);
            this.pb_GifMenu.Name = "pb_GifMenu";
            this.pb_GifMenu.Size = new System.Drawing.Size(597, 99);
            this.pb_GifMenu.TabIndex = 6;
            this.pb_GifMenu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(861, 486);
            this.Controls.Add(this.pb_GifMenu);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_help);
            this.Controls.Add(this.b_credits);
            this.Controls.Add(this.Start_Player2);
            this.Controls.Add(this.Start_Player1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Crack-Man ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GifMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start_Player1;
        private System.Windows.Forms.Button Start_Player2;
        private System.Windows.Forms.Button b_credits;
        private System.Windows.Forms.Button b_help;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.PictureBox pb_GifMenu;
    }
}