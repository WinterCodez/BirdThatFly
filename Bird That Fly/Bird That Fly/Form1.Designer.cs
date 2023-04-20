namespace Bird_That_Fly
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PIPE1 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PIPE2 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.PIPE3 = new System.Windows.Forms.PictureBox();
            this.PIPE4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE4)).BeginInit();
            this.SuspendLayout();
            // 
            // PIPE1
            // 
            this.PIPE1.Image = global::Bird_That_Fly.Properties.Resources.pipe;
            this.PIPE1.Location = new System.Drawing.Point(280, 394);
            this.PIPE1.Name = "PIPE1";
            this.PIPE1.Size = new System.Drawing.Size(100, 188);
            this.PIPE1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPE1.TabIndex = 0;
            this.PIPE1.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::Bird_That_Fly.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(12, 258);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(56, 49);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PIPE2
            // 
            this.PIPE2.BackColor = System.Drawing.Color.Transparent;
            this.PIPE2.Image = global::Bird_That_Fly.Properties.Resources.pipedown;
            this.PIPE2.Location = new System.Drawing.Point(415, -7);
            this.PIPE2.Name = "PIPE2";
            this.PIPE2.Size = new System.Drawing.Size(100, 229);
            this.PIPE2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPE2.TabIndex = 2;
            this.PIPE2.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Orchid;
            this.Ground.Image = global::Bird_That_Fly.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-36, 579);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(981, 134);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.OldLace;
            this.Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Location = new System.Drawing.Point(12, 633);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(134, 34);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimeEvent);
            // 
            // PIPE3
            // 
            this.PIPE3.Image = global::Bird_That_Fly.Properties.Resources.pipedown;
            this.PIPE3.Location = new System.Drawing.Point(747, -7);
            this.PIPE3.Name = "PIPE3";
            this.PIPE3.Size = new System.Drawing.Size(100, 196);
            this.PIPE3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPE3.TabIndex = 5;
            this.PIPE3.TabStop = false;
            // 
            // PIPE4
            // 
            this.PIPE4.Image = global::Bird_That_Fly.Properties.Resources.pipe;
            this.PIPE4.Location = new System.Drawing.Point(612, 361);
            this.PIPE4.Name = "PIPE4";
            this.PIPE4.Size = new System.Drawing.Size(100, 221);
            this.PIPE4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPE4.TabIndex = 6;
            this.PIPE4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(934, 699);
            this.Controls.Add(this.PIPE4);
            this.Controls.Add(this.PIPE3);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PIPE2);
            this.Controls.Add(this.PIPE1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.PIPE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPE4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIPE1;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PIPE2;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox PIPE3;
        private System.Windows.Forms.PictureBox PIPE4;
    }
}

