using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SyncroMachine;
using System.Media;


namespace SyncroMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int sampleRate = 8000;
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", Application.ProductName, MessageBoxButtons.YesNo) != DialogResult.No)
                Application.Exit();
        }
        SoundPlayer player;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                
                MessageBox.Show("Ошибка! Строка пуста. Введите пожалуйста данные.");
                return;
            }
            char[] charTrim = { ' ' };
            textBox1.Text = textBox1.Text.Trim(charTrim);
            
            Track test = new Track(sampleRate);
            test.Music(textBox1.Text, 70);
            test.Synthesize();
            Stream stream = new MemoryStream();
            test.SaveWave(stream);
            stream.Position = 0;
            player = new SoundPlayer(stream);
            player.PlayLooping();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Stop();
            textBox1.Clear();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A1";
        }

        private void A3_Click(object sender, EventArgs e)
        {
            

            textBox1.Text += " A3";
            
        }

        private void A0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A0";
        }

        private void A2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A2";
        }

        private void A4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A4";
        }

        private void A5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A5";
        }

        private void A6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A6";
        }

        private void A7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A7";
        }

        private void A8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A8";
        }

        private void A9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A9";
        }

        private void As0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#0";
        }

        private void As1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#1";
        }

        private void As2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#2";
        }

        private void As3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#3";
        }

        private void As4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#4";
        }

        private void As5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#5";
        }

        private void As6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#6";
        }

        private void As7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#7";
        }

        private void As8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#8";
        }

        private void As9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " A#9";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B1";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B0";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " B9";
        }

        private void C0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C0";
        }

        private void C1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C1";
        }

        private void C2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C2";
        }

        private void C3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C3";
        }

        private void C4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C4";
        }

        private void C5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C5";
        }

        private void C6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C6";
        }

        private void C7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C7";
        }

        private void C8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C8";
        }

        private void C9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C9";
        }

        private void Cs0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#0";
        }

        private void Cs1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#1";
        }

        private void Cs2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#2";
        }

        private void Cs3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#3";
        }

        private void Cs4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#4";
        }

        private void Cs5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#5";
        }

        private void Cs6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#6";
        }

        private void Cs7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#7";
        }

        private void Cs8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#8";
        }

        private void Cs9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " C#9";
        }

        private void D0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D0";
        }

        private void D1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D1";
        }

        private void D2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D2";

        }

        private void D3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D3";
        }

        private void D4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D4";
        }

        private void D5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D5";
        }

        private void D6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D6";
        }

        private void D7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D7";
        }

        private void D8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D8";
        }

        private void D9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D9";
        }

        private void Ds0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#0";
        }

        private void Ds1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#1";
        }

        private void Ds2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#2";
        }

        private void Ds3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#3";
        }

        private void Ds4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#4";
        }

        private void Ds5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#5";
        }

        private void Ds6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#6";
        }

        private void Ds7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#7";
        }

        private void Ds8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#8";
        }

        private void Ds9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " D#9";
        }

        private void E0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E0";
        }

        private void E1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E1";
        }

        private void E2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E2";
        }

        private void E3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E3";
        }

        private void E4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E4";
        }

        private void E5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E5";
        }

        private void E6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E6";
        }

        private void E7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E7";
        }

        private void E8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E8";
        }

        private void E9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " E9";
        }

        private void F0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F0";
        }

        private void F1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F1";
        }

        private void F2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F2";
        }

        private void F3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F3";
        }

        private void F4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F4";
        }

        private void F5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F5";
        }

        private void F6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F6";
        }

        private void F7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F7";
        }

        private void F8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F8";
        }

        private void F9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F9";
        }

        private void G0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G0";
        }

        private void G1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G1";
        }

        private void G2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G2";
        }

        private void G3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G3";
        }

        private void G4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G4";
        }

        private void G5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G5";
        }

        private void G6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G6";
        }

        private void G7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G7";
        }

        private void G8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G8";
        }

        private void G9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G9";
        }

        private void Fs0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#0";
        }

        private void Fs1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#1";
        }

        private void Fs2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#2";
        }

        private void Fs3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#3";
        }

        private void Fs4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#4";
        }

        private void Fs5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#5";
        }

        private void Fs6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#6";
        }

        private void Fs7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#7";
        }

        private void Fs8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#8";
        }

        private void Fs9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " F#9";
        }

        private void Gs0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#0";
        }

        private void Gs1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#1";
        }

        private void Gs2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#2";
        }

        private void Gs3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#3";
        }

        private void Gs4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#4";
        }

        private void Gs5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#5";
        }

        private void Gs6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#6";
        }

        private void Gs7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#7";
        }

        private void Gs8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#8";
        }

        private void Gs9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " G#9";
        }

        private void L0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L0";
        }

        private void L1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L1";
        }

        private void L2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L2";
        }

        private void L3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L3";
        }

        private void L4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L4";
        }

        private void L5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L5";
        }

        private void L6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L6";
        }

        private void L7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L7";
        }

        private void L8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L8";
        }

        private void L9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " L9";
        }

        private void S0_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S0";
        }

        private void S1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S1";
        }

        private void S2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S2";
        }

        private void S3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S3";
        }

        private void S4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S4";
        }

        private void S5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S5";
        }

        private void S6_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S6";
        }

        private void S7_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S7";
        }

        private void S8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S8";
        }

        private void S9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " S9";
        }




    }
}
