using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AlecScentum
{

    
    public partial class CreateAccountForm : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AlecScentumDB.mdf;Integrated Security=True;Connect Timeout=30";
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccountFormSubmit_Click(object sender, EventArgs e)
        {
            string surname = txtbCreateAccountFormSurname.Text.Trim();
            string firstname = txtbCreateAccountFormFirstrname.Text.Trim();
            string nickname = txtbCreateAccountFormNickname.Text.Trim();
            string password = txtbCreateAccountFormPassword.Text.Trim();
            string confirmPassword = txtbCreateAccountFormConfirmPassword.Text.Trim();
            string mail = txtbCreateAccountFormMail.Text.Trim();
            string phoneNumber = txtbCreateAccountFormPhoneNumber.Text.Trim();
            string adress1 = txtbCreateAccountFormAdress1.Text.Trim();
            string adress2 = txtbCreateAccountFormAdress2.Text.Trim();

            if (password != confirmPassword)
                return;
            
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    bool existedAccount = false;
                    cmd.CommandText = "INSERT INTO Users (UserFirstName, UserSurName, UserNickname, UserPassword, UserMail, UserPhoneNumber, UserAdress1, UserAdress2)" +
                        " VALUES (@firstname, @surname, @nickname, @password, @mail, @phone, @adress1, @adress2)";

                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@nickname", nickname);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@adress1", adress1);
                    cmd.Parameters.AddWithValue("@adress2", adress2);

                    /// Verificam daca mai exista un cont cu acelasi username sau email in baza de date

                    using (SqlCommand cmd2 = new SqlCommand("", conn))
                    {
                        cmd2.CommandText = $"SELECT * FROM Users WHERE UserNickname='{nickname}' OR UserMail='{mail}'";
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.HasRows || surname == string.Empty || firstname == string.Empty || nickname == string.Empty || password == string.Empty || confirmPassword == string.Empty || mail == string.Empty)
                            {
                                existedAccount = true;
                            }
                        }
                    }

                    if (existedAccount)
                    {
                        MessageBox.Show("An account with this email or nickname already exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbCreateAccountFormSurname.Text = "";
                        txtbCreateAccountFormPhoneNumber.Text = "";
                        txtbCreateAccountFormPassword.Text = "";
                        txtbCreateAccountFormNickname.Text = "";
                        txtbCreateAccountFormMail.Text = "";
                        txtbCreateAccountFormFirstrname.Text = "";
                        txtbCreateAccountFormConfirmPassword.Text = "";
                        txtbCreateAccountFormAdress2.Text = "";
                        txtbCreateAccountFormAdress1.Text = "";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An account was created!", "Created account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbCreateAccountFormSurname.Text = "";
                        txtbCreateAccountFormPhoneNumber.Text = "";
                        txtbCreateAccountFormPassword.Text = "";
                        txtbCreateAccountFormNickname.Text = "";
                        txtbCreateAccountFormMail.Text = "";
                        txtbCreateAccountFormFirstrname.Text = "";
                        txtbCreateAccountFormConfirmPassword.Text = "";
                        txtbCreateAccountFormAdress2.Text = "";
                        txtbCreateAccountFormAdress1.Text = "";
                    }

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }


        }

        private void txtbCreateAccountFormPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbCreateAccountFormPassword.Text.Contains(" "))
            {
                
            }
        }

        private void txtbCreateAccountFormConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbCreateAccountFormConfirmPassword.Text.Contains(" "))
            {

            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            using (OnClosingForm closingForm = new OnClosingForm())
            {

                var d = closingForm.ShowDialog();

                if (d == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch(Exception ex)
            {

            }


        }
    }
}
