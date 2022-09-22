using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjectCar
{
    public partial class frmCaminhao : Form
    {

        Caminhao caminhao;
        public frmCaminhao()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // txt que sera preenchida pelo usuario
            caminhao = new Caminhao(txtMarca.Text, txtPlaca.Text, txtCor.Text, txtCarga.Text, (Convert.ToInt32(txtCombustivel.Text)),
            txtCabine.Text, txtChassi.Text, txtPorte.Text);


            // limpando 

            txtCombustivel.Clear();
            txtPorte.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtCarga.Clear();
            txtCabine.Clear();

            txtPorte.Focus();


            // Caixa de mensagem caso o preenchimento seja cadastrado
            MessageBox.Show("Caminhão cadastrado!");


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // exibindo todo conteudo colocado nas txt 
            MessageBox.Show(caminhao.ApresentarDados());
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
