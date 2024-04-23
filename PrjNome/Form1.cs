using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjNome
{
    public partial class Form1 : Form
    {
        public static String nc = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXT_nm.Clear();// metodo clear apaga o texto
            TXT_sn.Clear();
            lbl_nc.Text = "";
            TXT_nm.Focus();// focus coloca o cursor na caixa de texto
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();  // fecha a aplicação
                      // Application.Exit(); -> fecha todo o formulário
        }
        private void lbl_nm_Click(object sender, EventArgs e)
        {

        }

        private void BTN_exit_MouseMove(object sender, MouseEventArgs e)
        {
//   BTN_exit.Left += 10;
        }

        private void BTN_nc_Click(object sender, EventArgs e)
        {
            //declarar variavel
            String nome="", sobre="";
            nome = TXT_nm.Text; //atribui o texto da caixa na variavel
            sobre = TXT_sn.Text;
            nc = nome + " " + sobre;

            //adição do valor no label
            lbl_nc.Text = nc;
            //criação de uma caixa de mensagem
            MessageBox.Show(nc,"Nome Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
