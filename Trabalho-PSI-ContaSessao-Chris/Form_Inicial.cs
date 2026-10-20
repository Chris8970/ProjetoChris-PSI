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
    public partial class Form_Inicial : Form
    {
        public Form_Inicial()
        {
            InitializeComponent();
        }

        private void button_Logo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo (a) ao InstaSpam!");
        }
    }
}
