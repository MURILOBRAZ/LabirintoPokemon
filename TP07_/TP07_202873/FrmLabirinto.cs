using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TP07_202873
{
    public partial class FrmLabirinto : Form
    {
        #region Variaveis Globais 
        
        static string[,] maze = new string[30, 43]

               {{"0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","0",},
                {"0","1","1","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","1","0","0",},
                {"0","1","1","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","1","0","0",},
                {"0","1","1","1","1","0","0","1","1","1","0","1","1","1","1","1","1","1","1","1","1","0","1","1","1","1","1","1","0","1","1","1","1","1","1","1","1","1","0","1","1","0","0",},
                {"0","1","1","1","1","0","0","1","0","1","0","1","1","0","0","0","0","0","0","1","1","0","1","1","0","0","0","1","0","1","0","0","0","0","0","0","0","1","0","1","1","0","0",},
                {"0","1","0","0","1","0","0","1","0","1","0","1","1","0","1","1","1","1","0","1","1","0","1","1","1","1","0","1","0","1","0","0","1","1","1","1","1","1","0","1","1","0","0",},
                {"0","1","0","0","1","0","0","1","0","1","0","1","1","0","1","0","0","1","0","1","1","0","1","1","1","1","0","1","0","1","0","0","0","0","0","0","0","0","0","1","1","0","0",},
                {"0","1","0","0","1","0","0","1","0","1","0","1","1","0","1","0","0","1","0","1","1","0","0","0","0","0","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","0","0",},
                {"0","1","0","0","1","0","0","1","0","1","0","1","1","0","1","0","0","1","0","1","1","1","1","1","1","1","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","0","0",},
                {"0","1","0","0","1","0","0","1","0","1","0","1","1","0","1","0","0","0","0","0","0","0","1","0","0","0","0","0","0","1","0","0","0","0","0","0","0","0","0","1","1","0","0",},
                {"0","1","0","0","1","1","1","1","0","1","0","1","1","0","1","0","0","1","1","1","1","0","1","1","1","1","1","1","1","1","0","0","1","1","1","1","1","1","1","1","1","0","0",},
                {"0","1","0","0","0","0","0","0","0","0","0","1","1","0","1","0","0","1","0","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0",},
                {"0","1","0","0","0","0","0","0","0","0","0","1","1","0","1","0","0","1","0","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0",},
                {"0","1","1","1","1","1","1","1","1","1","0","1","1","0","1","1","1","1","0","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","1","1","1","1","1","1","0","0",},
                {"0","1","1","1","1","1","1","1","1","1","0","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","0","0","0","0","0","1","1","0","0",},
                {"0","0","0","0","0","0","0","0","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","0","1","0","1","0","0","1","1","1","0","1","1","0","0",},
                {"0","1","1","1","1","1","1","1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","0","1","0","1","0","0","1","1","1","0","1","1","0","0",},
                {"0","1","0","0","0","0","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","1","0","1","0","0","1","0","1","0","0","1","0","1","0","1","1","0","0",},
                {"0","1","1","1","1","0","0","1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","0","0","1","0","1","0","0","1","0","1","0","1","1","0","0",},
                {"0","1","0","1","1","0","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","0","1","0","1","0","0","1","0","1","0","1","1","0","0",},
                {"0","1","0","1","1","0","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","1","0","0","1","0","1","0","0","1","0","1","0","1","1","0","0",},
                {"0","1","0","1","1","0","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","1","1","1","0","0","1","0","1","0","0","1","0","1","0","1","1","0","0",},
                {"0","1","0","1","1","0","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","0","0","1","0","1","0","0","1","0","0","0","1","1","0","0",},
                {"0","1","0","1","1","0","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","0","0","1","0","1","0","0","1","0","0","0","1","1","0","0",},
                {"0","1","0","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","1","1","1","1","0","1","0","0","1","0","1","1","1","1","0","0",},
                {"0","1","0","1","1","0","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","1","1","0","1","0","0","1","0","1","1","1","1","1","0",},
                {"0","1","0","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","0","1","0","1","1","1","1","1","0",},
                {"0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","1","1","0",},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0",},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0",},};
                

        int posLinha = 1, posColuna = 1, contagem = 60;
        int auxPokebola1, auxPokebola2, auxPokebola3, auxPokebola4, auxPokebola5;
        string Controle;
        #endregion

        #region Form
        public FrmLabirinto()
        {
            InitializeComponent();
            Timer2.Start();
            timer3.Start();
            SoundPlayer Soundtrack = new SoundPlayer("PokemonSoundtrack.wav");
            Soundtrack.Play();
        }
        #endregion

        #region Ícone Fechar
        private void FrmLabirinto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerando o Aplicativo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region Verificar Teclas

        private void FrmLabirinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == "A" || e.KeyChar.ToString().ToUpper() == "D" ||
                e.KeyChar.ToString().ToUpper() == "W" || e.KeyChar.ToString().ToUpper() == "S")
            {
                Controle = e.KeyChar.ToString().ToUpper();
                timer1.Start();
            }

            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region LIXO
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }
        private void FrmLabirinto_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Pokebolas Boost
        private void timer3_Tick(object sender, EventArgs e)
        {

            int x = PbxAsh.Location.X;
            int y = PbxAsh.Location.Y;

            if ((x == 616) && (y == 375) || (x == 616) && (y == 390) || (x == 616) && (y == 405) || (x == 616) && (y == 420))
            {
                timer3.Stop();
                Timer2.Stop();
                if (MessageBox.Show("REINICIAR O GAME!", "VOCê GANHOU!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    posLinha = 1;
                    posColuna = 1;
                    contagem = 60;
                    PbxAsh.Location = new Point(31, 30);
                    auxPokebola1 = 0;
                    auxPokebola2 = 0;
                    auxPokebola3 = 0;
                    auxPokebola4 = 0;
                    auxPokebola5 = 0;
                    Timer2.Start();
                    timer3.Start();
                    SoundPlayer Soundtrack = new SoundPlayer("PokemonSoundtrack.wav");
                    Soundtrack.Play();
                    PbxPoke1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                    PbxPoke2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                    PbxPoke3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                    PbxPoke4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                    PbxPoke5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                }
                else
                {
                    this.Close();
                }
            }

            if ((x == 316) && (y == 15))
            {
                PbxPoke1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Vazio.png");
                auxPokebola1 += 1;

                if(auxPokebola1 == 1)
                {
                contagem = contagem + 1;
                lblTimer.Text = contagem + "  Segundos";
                    auxPokebola1 = 2;
                }
            }
            if ((x == 301) && (y == 210))
            {
                PbxPoke2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Vazio.png");
                auxPokebola2 += 1;

                if (auxPokebola2 == 1)
                {
                    contagem = contagem + 1;
                    lblTimer.Text = contagem + "  Segundos";
                    auxPokebola2 = 2;
                }
            }
            if ((x == 121) && (y == 225))
            {
                PbxPoke3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Vazio.png");
                auxPokebola3 += 1;

                if (auxPokebola3 == 1)
                {
                    contagem = contagem + 1;
                    lblTimer.Text = contagem + "  Segundos";
                    auxPokebola3 = 2;
                }
            }
            if ((x == 61) && (y == 300) || (x == 76) && (y == 300))
            {
                PbxPoke4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Vazio.png");
                auxPokebola4 += 1;

                if (auxPokebola4 == 1)
                {
                    contagem = contagem + 10;
                    lblTimer.Text = contagem + "  Segundos";
                    auxPokebola4 = 2;
                }
            }
            if ((x == 586) && (y == 210))
            {
                PbxPoke5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Vazio.png");
                auxPokebola5 += 1;

                if (auxPokebola5 == 1)
                {
                    contagem = contagem + 1;
                    lblTimer.Text = contagem + "  Segundos";
                    auxPokebola5 = 2;
                }
            }
        }
        #endregion

        #region Timer
        private void Timer2_Tick(object sender, EventArgs e)
        {

            if (contagem > 0)
            {
                contagem--;
                lblTimer.Text = contagem + "  Segundos";
            }
            else
            {
                Timer2.Stop();
                timer3.Stop();
                MessageBox.Show("GAME OVER");
                posLinha = 1;
                posColuna = 1;
                contagem = 60;
                PbxAsh.Location = new Point(31, 30);
                auxPokebola1 = 0;
                auxPokebola2 = 0;
                auxPokebola3 = 0;
                auxPokebola4 = 0;
                auxPokebola5 = 0;
                Timer2.Start();
                timer3.Start();
                SoundPlayer Soundtrack = new SoundPlayer("PokemonSoundtrack.wav");
                Soundtrack.Play();
                PbxPoke1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                PbxPoke2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                PbxPoke3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                PbxPoke4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
                PbxPoke5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pokebola.png");
            }

            
        }
        #endregion

        #region Movimento do AVATAR
        private void timer1_Tick(object sender, EventArgs e)
        {

            int x = PbxAsh.Location.X;
            int y = PbxAsh.Location.Y;

            lblX.Text = x.ToString();
            lblY.Text = y.ToString();

            lblColuna.Text = posLinha.ToString();
            lblLinha.Text = posColuna.ToString();

            if ((x == 600) && (y == 390))
            {
                timer1.Stop();
                Timer2.Stop();
                MessageBox.Show("Chegou na saída...", "Fim de Jogo");
            }

            else if (Controle == "A")
            {

                PbxAsh.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\AshA.png");

                if (posColuna == 0) return;

                if (maze[posLinha, posColuna - 1] == "1")
                {
                    PbxAsh.Location = new Point(x - 15, y);
                    posColuna--;
                }
            }

            else if (Controle == "D")
            {
                PbxAsh.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\AshD.png");

                if (posColuna == 64) return;

                if (maze[posLinha, posColuna + 1] == "1")
                {
                    PbxAsh.Location = new Point(x + 15, y);
                    posColuna++;
                }
            }

            else if (Controle == "W")
            {
                PbxAsh.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\AshW.png");

                if (posLinha == 0) return;

                if (maze[posLinha - 1, posColuna] == "1")
                {
                    PbxAsh.Location = new Point(x, y - 15);
                    posLinha--;
                }
            }

            else if (Controle == "S")
            {
                PbxAsh.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\AshS.png");

                if (posLinha == 33) return;

                if (maze[posLinha + 1, posColuna] == "1")
                {
                    PbxAsh.Location = new Point(x, y + 15);
                    posLinha++;
                }
            }

            timer1.Stop();
        }
        #endregion
    }
}
