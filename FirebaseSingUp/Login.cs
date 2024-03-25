using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace FirebaseSingUp
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("Host=sql6.freesqldatabase.com;Database=sql6694070;User Id=sql6694070;Password=4xc4UidE5S;Port=3306;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userText.Text) || string.IsNullOrEmpty(passText.Text))
                {
                    MessageBox.Show("Please input Username and Password", "Error");
                    return;
                }

                connection.Open();
                string selectQuery = "SELECT * FROM userinfo WHERE Username = @Username AND Password = @Password";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@Username", userText.Text);
                command.Parameters.AddWithValue("@Password", passText.Text);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
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