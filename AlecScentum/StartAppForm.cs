using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace AlecScentum
{
    public partial class StartAppForm : Form
    {

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AlecScentumDB.mdf;Integrated Security=True;Connect Timeout=30";
        bool parfumer = false;
        Color askForAccountInitialColor, askForAccountSecondColor = Color.BlueViolet;

        public static string UserID;

        public StartAppForm()
        {
            InitializeComponent();


            askForAccountInitialColor = lblStartAppFormAskIfDoNotHaveAccount.ForeColor;
        }

        private void btnStartAppFormSubmitLogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    string cmdText, Name, Password;
                    Name = txtbStartAppFormNicknameOrMail.Text.Trim();
                    Password = txtbStartAppFormPassword.Text.Trim();


                    
                        cmdText = $"SELECT * FROM Users WHERE (UserNickname='{Name}' AND UserPassword='{Password}')";
                    

                    cmd.CommandText = cmdText;
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Daca exista cont aflam id pentru a prelucra datele in viitor
                        if (reader.HasRows)
                        {
                            reader.Read();
                            //MessageBox.Show("Logged IN!");


                            UserID = reader["UserID"].ToString();

                            MainPageForm mainPageForm = new MainPageForm();
                            mainPageForm.Show();

                            txtbStartAppFormNicknameOrMail.Text = "";
                            txtbStartAppFormPassword.Text = "";


                        }
                        else
                        {
                            MessageBox.Show("An account with this name or password does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }

                conn.Close();

            }
        }

 

        private void lblStartAppFormAskIfDoNotHaveAccount_MouseEnter(object sender, EventArgs e)
        {
            lblStartAppFormAskIfDoNotHaveAccount.ForeColor = askForAccountSecondColor;
        }

        private void lblStartAppFormAskIfDoNotHaveAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.ShowDialog(this);
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
                    if (d == DialogResult.Yes)
                    {
                        try
                        {
                            this.Dispose();
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }
            }
        }

        private void lblStartAppFormAskIfDoNotHaveAccount_MouseLeave(object sender, EventArgs e)
        {
            lblStartAppFormAskIfDoNotHaveAccount.ForeColor = askForAccountInitialColor;
        }
    }
}
