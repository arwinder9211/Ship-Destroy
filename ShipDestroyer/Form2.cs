using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ShipDestroyer
{
    public partial class Form2 : Form
    {
        private SoundPlayer _soundPlayer1;
        private SoundPlayer _soundPlayer;
        public Form2()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer(@"C:\Users\thispc\source\repos\Shooting Game\spin.wav");

            _soundPlayer1 = new SoundPlayer(@"C:\Users\thispc\source\repos\Shooting Game\Gun+Reload.wav");

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            _soundPlayer1.Play();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
