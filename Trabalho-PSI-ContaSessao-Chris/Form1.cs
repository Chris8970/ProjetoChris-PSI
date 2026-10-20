using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_PSI_ContaSessao_Chris
{
    public partial class Form_IniciarSessao : Form
    {
        public Form_IniciarSessao()
        {
            InitializeComponent();
        }

        private void button_Logo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo (a) ao InstaSpam!");
        }

        private void button_Comecar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Inicial form_Inicial = new Form_Inicial();
            form_Inicial.ShowDialog();
            this.Show();

        }
    }
}
