using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadastro_de_animais.controller;
using cadastro_de_animais.model;

namespace cadastro_de_animais.veiw
{
    public partial class TelaCadastroAnimais : Form
    {
        public TelaCadastroAnimais()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Animais.Nome = tbx_nome.Text;
            Animais.Raca = tbx_raca.Text;
            Animais.Porte = cbx_porte.Text;

            controllerAnimais ControllerAnimais = new controllerAnimais();
            ControllerAnimais.EnviarBanco();
        }
    }
}
