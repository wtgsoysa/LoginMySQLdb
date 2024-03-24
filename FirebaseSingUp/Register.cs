using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace FirebaseSingUp
{
    public partial class Register : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullText.Text) || string.IsNullOrEmpty(userText.Text) || string.IsNullOrEmpty(passText.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            connection.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.userinfo WHERE Username = @UserName", connection);

            cmd1.Parameters.AddWithValue("@UserName", userText.Text);

            bool userExists = false;

            using (var dr1 = cmd1.ExecuteReader())
                if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

            if (!userExists)
            {
                string iquery = "INSERT INTO loginform.userinfo(`ID`, `FirstName`, `Username`, `Password`) VALUES (NULL, '" + fullText.Text + "', '" + userText.Text + "', '" + passText.Text + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");
            }

            connection.Close();
        }

        private void toLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm4 = new Login();
            frm4.ShowDialog();
        }
    }
}
