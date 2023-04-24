using System.Diagnostics.Eventing.Reader;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string user = "Admin";
        string pass = "123";
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Enter(object sender, EventArgs e)
        {

            if (Usuario.Text == "Usuario")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.White;
                Usuario.SelectAll();
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Usuario";
                Usuario.ForeColor = Color.DimGray;
            }
        }

        private void Contraseņa_Enter(object sender, EventArgs e)
        {
            if (Contraseņa.Text == "Contraseņa")
            {
                Contraseņa.Text = "";
                Contraseņa.ForeColor = Color.White;
                Contraseņa.UseSystemPasswordChar = true;
                Contraseņa.SelectAll();
            }
        }

        private void Contraseņa_Leave(object sender, EventArgs e)
        {
            if (Contraseņa.Text == "")
            {
                Contraseņa.Text = "Contraseņa";
                Contraseņa.ForeColor = Color.DimGray;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            string user2 = Usuario.Text;
            string contra = Contraseņa.Text;

            if (user2.Equals(user))
            {
                if (contra.Equals(pass))
                {
                    Menu_Principal menuprincipal = new Menu_Principal();
                    menuprincipal.ShowDialog();


                }
            }

            else
            {
                labelError.Visible = true;
                this.DialogResult = DialogResult.None;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}