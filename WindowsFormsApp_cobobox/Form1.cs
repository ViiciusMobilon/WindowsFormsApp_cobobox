using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_cobobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bntinserir_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(txtinserir.Text);

            lblquantidade.Text = comboBox1.Items.Count.ToString();
            txtinserir.Clear();
            texto.Select();
        }

        private void bntOrdenarcombo_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void bntlimpar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                lblquantidade.Text = comboBox1.Items.Count.ToString();

                comboBox1.ResetText();
            }
        }

        private void bntexibir_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                txtConteudo.Text = comboBox1.Text.ToString();
                txtindice.Text = comboBox1.Items.Count.ToString();
                
            }
        }
    }
}
