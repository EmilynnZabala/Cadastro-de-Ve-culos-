using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCar
{
    public partial class frmCarro : Form
    {

        Carro carro;
        public frmCarro()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // txt que sera preenchida pelo usuario
            carro = new Carro(txtMarca.Text, txtPlaca.Text, txtCor.Text, txtCarroceria.Text, (Convert.ToInt32(txtCombustivel.Text)),
            txtBagageiro.Text, (Convert.ToInt32(txtQtdPortas.Text)), txtChassi.Text);


            // limpando 
            txtCombustivel.Clear();
            txtBagageiro.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtQtdPortas.Clear();
            txtCarroceria.Clear();
            txtBagageiro.Clear();

            MessageBox.Show("Carro cadastrado!");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // exibindo todo conteudo colocado nas txt 
            MessageBox.Show(carro.ApresentarDados());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // voltando ao menu principal 
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
