using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySqlConnector;

namespace FirebaseSingUp
{
    public partial class LoginSuccess : Form
    {
        private readonly string username;
        private readonly MySqlConnection connection;

        public LoginSuccess(string username)
        {
            InitializeComponent();
            this.username = username;
            connection = new MySqlConnection("server=localhost;database=loginform;port=3306;username=root;password=");
            PopulateProfile();
        }

        private void PopulateProfile()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM userinfo WHERE Username = @Username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblFullName.Text = reader["FirstName"].ToString();
                        lblEmail.Text = reader["Username"].ToString();
                        lblOccupation.Text = reader["Occupation"].ToString();

                        // Retrieve profile image data and display
                        if (!reader.IsDBNull(reader.GetOrdinal("ProfileImage")))
                        {
                            byte[] imageData = (byte[])reader["ProfileImage"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxProfile.Image = Image.FromStream(ms);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                this.Close(); // Close the form in case of an error
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login();
            frm1.ShowDialog();
        }

        private void LoginSuccess_Load(object sender, EventArgs e)
        {
            // Form is already loaded, no additional action needed
        }
    }
}
