namespace ProjectCar
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCarro carro = new frmCarro();
            this.Hide();
            carro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCaminhao caminhao = new frmCaminhao();
            this.Hide();
            caminhao.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}