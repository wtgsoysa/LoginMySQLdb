using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace FirebaseSingUp
{
    public partial class Register : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER= triploo.site;PORT=3306;DATABASE=id21566778_studeelogin;UID=id21566778_studeelogin;PASSWORD=Gd%7%nsn");

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(fullText.Text) || string.IsNullOrEmpty(userText.Text) || string.IsNullOrEmpty(passText.Text))
                {
                    MessageBox.Show("Please fill out all information!", "Error");
                    return;
                }

                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM userinfo WHERE Username = @UserName", connection);

                cmd1.Parameters.AddWithValue("@UserName", userText.Text);

                bool userExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                if (!userExists)
                {
                    string iquery = "INSERT INTO userinfo(`ID`, `FirstName`, `Username`, `Password`) VALUES (NULL, @FullName, @UserName, @Password)";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.Parameters.AddWithValue("@FullName", fullText.Text);
                    commandDatabase.Parameters.AddWithValue("@UserName", userText.Text);
                    commandDatabase.Parameters.AddWithValue("@Password", passText.Text);
                    commandDatabase.CommandTimeout = 60;

                    commandDatabase.ExecuteNonQuery();

                    MessageBox.Show("Account Successfully Created!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
        }


        private void toLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm4 = new Login();
            frm4.ShowDialog();
        }
    }
}