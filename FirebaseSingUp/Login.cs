using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace FirebaseSingUp
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=loginform;port=3306;username=root;password=");
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
                    string loggedInUsername = userText.Text; // Replace with the actual username obtained during login
                    LoginSuccess loginSuccessForm = new LoginSuccess(loggedInUsername);
                    loginSuccessForm.ShowDialog();

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