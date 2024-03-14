using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btologin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "admin" && mtxsenha.Text == "ra2357030")
                MessageBox.Show("Acesso negado");
            else
                MessageBox.Show("Acesso permitido");
        }

        private void ckbsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbsenha.Checked)
                mtxsenha.PasswordChar = '\0';
            else
                mtxsenha.PasswordChar = '*';
        }
    }
}
