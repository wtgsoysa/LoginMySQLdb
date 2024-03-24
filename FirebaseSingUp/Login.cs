using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace FirebaseSingUp
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userText.Text) || string.IsNullOrEmpty(passText.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + userText.Text + "' AND Password = '" + passText.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    LoginSuccess frm2 = new LoginSuccess();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void toReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm3 = new Register();
            frm3.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
