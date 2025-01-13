using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{

    
    public partial class Form1 : Form
    {
        public int tiklamaSayisi = 0;
        int[,] kontrol;
        public Form1()
        {
            InitializeComponent();
            kontrol = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    kontrol[i, j] = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string OyuncuKontol(int tiklanmasayisi)
        {
            if (tiklanmasayisi % 2 == 0)
            {
                
                label1.Text = "PLAYER 1";
                return @"C:\Users\Samet\source\repos\TikTakToe\TikTakToe\image\images1.png";
            }
            else
            {
                label1.Text = "PLAYER 2";
                return @"C:\Users\Samet\source\repos\TikTakToe\TikTakToe\image\images2.png";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 0, 0);
            pictureBox2.Image = Image.FromFile(fotograf);
            pictureBox2.Enabled = false;
            KazananMesaj(Player1Kontrol());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 0, 1);
            pictureBox3.Image = Image.FromFile(fotograf);
            pictureBox3.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 0, 2);
            pictureBox4.Image = Image.FromFile(fotograf);
            pictureBox4.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 1, 0);
            pictureBox11.Image = Image.FromFile(fotograf);
            pictureBox11.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 1, 1);
            pictureBox5.Image = Image.FromFile(fotograf);
            pictureBox5.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 1,2);
            pictureBox6.Image = Image.FromFile(fotograf);
            pictureBox6.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 2, 0);
            pictureBox7.Image = Image.FromFile(fotograf);
            pictureBox7.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 2, 1);
            pictureBox8.Image = Image.FromFile(fotograf);
            pictureBox8.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tiklamaSayisi++;
            string fotograf = @OyuncuKontol(tiklamaSayisi);
            Atama(fotograf, 2, 2);
            pictureBox9.Image = Image.FromFile(fotograf);
            pictureBox9.Enabled = false;
            KazananMesaj(Player1Kontrol());
        }

        public void Atama(string yol,int satir, int sutun)
        {
            if (yol.Equals(@"C:\Users\Samet\source\repos\TikTakToe\TikTakToe\image\images1.png"))
            {
                kontrol[satir, sutun] = 2;
            }
            else
            {
                kontrol[satir, sutun] = 1;
            }
        }
        public int Player1Kontrol()
        {
            
                // Yatayda kontrol
                for (int i = 0; i < 3; i++)
                {
                    if (kontrol[i, 0] != 0 && kontrol[i, 0] == kontrol[i, 1] && kontrol[i, 1] == kontrol[i, 2])
                    {
                        return kontrol[i, 0]; // X için 1, O için 2
                    }
                }

                // Dikeyde kontrol
                for (int j = 0; j < 3; j++)
                {
                    if (kontrol[0, j] != 0 && kontrol[0, j] == kontrol[1, j] && kontrol[1, j] == kontrol[2, j])
                    {
                        return kontrol[0, j]; // X için 1, O için 2
                    }
                }

                // Çaprazlarda kontrol
                if (kontrol[0, 0] != 0 && kontrol[0, 0] == kontrol[1, 1] && kontrol[1, 1] == kontrol[2, 2])
                {
                    return kontrol[0, 0]; // X için 1, O için 2
                }
                if (kontrol[0, 2] != 0 && kontrol[0, 2] == kontrol[1, 1] && kontrol[1, 1] == kontrol[2, 0])
                {
                    return kontrol[0, 2]; // X için 1, O için 2
                }

                // Eğer kazanan yoksa
                return 0;
            
        }
        public void KazananMesaj(int kazanan)
        {
            
            if (kazanan == 1)
            {
                MessageBox.Show("Player 1 kazandı!");
                OyunuSifirla();
            }
            else if (kazanan == 2)
            {
                MessageBox.Show("Player 2 kazandı!");
                OyunuSifirla();
            }
            else if (tiklamaSayisi == 9) // Eğer tüm hücreler doluysa ve kazanan yoksa
            {
                MessageBox.Show("Berabere!");
                OyunuSifirla();
            }
        }
        private void OyunuSifirla()
        {
            tiklamaSayisi = 0;
            label1.Text = "PLAYER 1";
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox11.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kontrol[i, j] = 0; // Tüm hücreleri boş olarak ayarlıyoruz
                }
            }


        }
    }
}
