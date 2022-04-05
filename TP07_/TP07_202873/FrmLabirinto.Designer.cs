namespace TP07_202873
{
    partial class FrmLabirinto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLabirinto));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblColuna = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxAsh = new System.Windows.Forms.PictureBox();
            this.PbxPoke2 = new System.Windows.Forms.PictureBox();
            this.PbxPoke4 = new System.Windows.Forms.PictureBox();
            this.PbxPoke3 = new System.Windows.Forms.PictureBox();
            this.PbxPoke5 = new System.Windows.Forms.PictureBox();
            this.PbxPoke1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAsh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Interval = 1000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::TP07_202873.Properties.Resources.Poster_Pokemon_Lateral;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblLinha);
            this.panel2.Controls.Add(this.lblColuna);
            this.panel2.Controls.Add(this.lblY);
            this.panel2.Controls.Add(this.lblX);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(678, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 501);
            this.panel2.TabIndex = 1;
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(152, 206);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(35, 13);
            this.lblLinha.TabIndex = 7;
            this.lblLinha.Text = "label2";
            // 
            // lblColuna
            // 
            this.lblColuna.AutoSize = true;
            this.lblColuna.Location = new System.Drawing.Point(21, 204);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(35, 13);
            this.lblColuna.TabIndex = 6;
            this.lblColuna.Text = "label1";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(152, 229);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "label1";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(24, 229);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TP07_202873.Properties.Resources.Teclas_WASDText;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 52);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TP07_202873.Properties.Resources.Teclas_WASD;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(24, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 146);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 143);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(208, 39);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00 Segundos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP07_202873.Properties.Resources.TempoRestante;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TP07_202873.Properties.Resources.MapaPokemon;
            this.panel1.Controls.Add(this.PbxAsh);
            this.panel1.Controls.Add(this.PbxPoke2);
            this.panel1.Controls.Add(this.PbxPoke4);
            this.panel1.Controls.Add(this.PbxPoke3);
            this.panel1.Controls.Add(this.PbxPoke5);
            this.panel1.Controls.Add(this.PbxPoke1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 501);
            this.panel1.TabIndex = 0;
            // 
            // PbxAsh
            // 
            this.PbxAsh.Image = ((System.Drawing.Image)(resources.GetObject("PbxAsh.Image")));
            this.PbxAsh.ImageLocation = "";
            this.PbxAsh.Location = new System.Drawing.Point(31, 30);
            this.PbxAsh.Name = "PbxAsh";
            this.PbxAsh.Size = new System.Drawing.Size(33, 37);
            this.PbxAsh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAsh.TabIndex = 2;
            this.PbxAsh.TabStop = false;
            // 
            // PbxPoke2
            // 
            this.PbxPoke2.Image = global::TP07_202873.Properties.Resources.Pokebola;
            this.PbxPoke2.Location = new System.Drawing.Point(294, 180);
            this.PbxPoke2.Name = "PbxPoke2";
            this.PbxPoke2.Size = new System.Drawing.Size(49, 50);
            this.PbxPoke2.TabIndex = 7;
            this.PbxPoke2.TabStop = false;
            // 
            // PbxPoke4
            // 
            this.PbxPoke4.Image = global::TP07_202873.Properties.Resources.Pokebola;
            this.PbxPoke4.Location = new System.Drawing.Point(54, 323);
            this.PbxPoke4.Name = "PbxPoke4";
            this.PbxPoke4.Size = new System.Drawing.Size(49, 50);
            this.PbxPoke4.TabIndex = 6;
            this.PbxPoke4.TabStop = false;
            // 
            // PbxPoke3
            // 
            this.PbxPoke3.Image = global::TP07_202873.Properties.Resources.Pokebola;
            this.PbxPoke3.Location = new System.Drawing.Point(129, 215);
            this.PbxPoke3.Name = "PbxPoke3";
            this.PbxPoke3.Size = new System.Drawing.Size(49, 50);
            this.PbxPoke3.TabIndex = 5;
            this.PbxPoke3.TabStop = false;
            // 
            // PbxPoke5
            // 
            this.PbxPoke5.Image = global::TP07_202873.Properties.Resources.Pokebola;
            this.PbxPoke5.Location = new System.Drawing.Point(599, 215);
            this.PbxPoke5.Name = "PbxPoke5";
            this.PbxPoke5.Size = new System.Drawing.Size(49, 50);
            this.PbxPoke5.TabIndex = 4;
            this.PbxPoke5.TabStop = false;
            // 
            // PbxPoke1
            // 
            this.PbxPoke1.Image = global::TP07_202873.Properties.Resources.Pokebola;
            this.PbxPoke1.Location = new System.Drawing.Point(321, 11);
            this.PbxPoke1.Name = "PbxPoke1";
            this.PbxPoke1.Size = new System.Drawing.Size(49, 50);
            this.PbxPoke1.TabIndex = 3;
            this.PbxPoke1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::TP07_202873.Properties.Resources._493;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(610, 394);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 78);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TP07_202873.Properties.Resources.Pikachu;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-10, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 58);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FrmLabirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLabirinto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeLabirinto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLabirinto_FormClosing);
            this.Load += new System.EventHandler(this.FrmLabirinto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLabirinto_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxAsh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox PbxAsh;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.PictureBox PbxPoke1;
        private System.Windows.Forms.PictureBox PbxPoke2;
        private System.Windows.Forms.PictureBox PbxPoke4;
        private System.Windows.Forms.PictureBox PbxPoke3;
        private System.Windows.Forms.PictureBox PbxPoke5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblColuna;
    }
}