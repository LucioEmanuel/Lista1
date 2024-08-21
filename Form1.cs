//Por Lúcio e Filipe, turma 2-51
//Codigo de um visualizador de fotos de carros

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;

//Por Lúcio e Filipe

namespace Lúcio251
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotoDosCarros = Directory.GetFiles(@"C:\Users\LAB TECH 13\Documents\251\CarrosLucio");
            foreach (string img in nomeFotoDosCarros)
            {
                string[] separador = img.Split('\\');
                string[] nomeCarro = separador[6].Split('.');
                if (comboBox2.Text == nomeCarro[0]) {
                    pictureBox1.ImageLocation = @"C:\\Users\\LAB TECH 13\\Documents\\251\\CarrosLucio\\" + comboBox2.Text + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            if (comboBox1.Text == "Toyota")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Supra 96");
                comboBox2.Items.Add("Supra GR 2024");

            }
            else if (comboBox1.Text == "Chevrolet")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Impala 67");
                comboBox2.Items.Add("Camaro 2012");
            }
            else if (comboBox1.Text == "Fiat")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Uno 2012");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
