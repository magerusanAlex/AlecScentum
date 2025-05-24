using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AlecScentum
{
    public partial class MainPageForm : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AlecScentumDB.mdf;Integrated Security=True;Connect Timeout=30";
        private User currentUser = new User();
        int rows;
        int cols;
        string[] images = new string[1000];

        int imgIndex = 0; /// Indexul Imaginii de la picture box pentru a trata evnimentul click
        public MainPageForm()
        {
            InitializeComponent();


            rows = tableLayoutPanel2.RowCount;
            cols = tableLayoutPanel2.ColumnCount;

            lblMainPageFormNickname.MouseClick += OnClick;
    

            SetUpUserInfo();

            SetUpTabControl();
            
            SetUpGrid();
        }





        private void SetUpUserInfo()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    cmd.CommandText = $"SELECT * FROM Users WHERE UserID='{StartAppForm.UserID}'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                currentUser.FirstName = reader["UserFirstName"].ToString();
                                currentUser.SurName = reader["UserSurName"].ToString();
                                currentUser.NickName = reader["UserNickname"].ToString();
                                currentUser.Password = reader["UserPassword"].ToString();
                                currentUser.Email = reader["UserMail"].ToString();
                                currentUser.Phone = reader["UserPhoneNumber"].ToString();
                                currentUser.Adress = reader["UserAdress1"].ToString() + reader["UserAdress2"].ToString();
                                currentUser.ProfilePhoto = reader["UserProfilePicture"].ToString();
                                currentUser.Font = reader["UserTextFont"].ToString();
                                currentUser.Color = reader["UserTextColor"].ToString();
                                currentUser.FontSize = reader["UserFontSize"].ToString();
                            }
                        }
                    }
                }
                conn.Close();
            }

            float size;
            float.TryParse(currentUser.FontSize, out size);

            lblMainPageFormNickname.ForeColor = Color.FromName(currentUser.Color);
            if (size != 0.0)
                lblMainPageFormNickname.Font = new Font(currentUser.Font, size);

            lblMainPageFormNickname.Text += "Username: " + currentUser.FirstName + '\n' +
                "Nickname: " + currentUser.NickName;


        }


        private void SetUpWishlist()
        {
            richTextBox1.Text = string.Empty;
            using (SqlConnection sql = new SqlConnection(connStr))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("", sql))
                {
                    cmd.CommandText = $"SELECT DISTINCT FragranceName FROM Wishlist WHERE UserID='{StartAppForm.UserID}'";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            richTextBox1.Text += reader[0].ToString() + '\n';
                        }

                    }
                }
                sql.Close();
            }
        }
        private void SetUpTabControl()
        {
            tabcMainPageForm.TabPages[0].Text = "See All Fragrance Houses";
            tabcMainPageForm.TabPages[1].Text = "My Wishlist";
            
        }

        private void SetUpGrid()
        {

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                {
                    GroupBox gr = new GroupBox();
                    PictureBox pictureBox = new PictureBox();
                    gr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (i == 0 && j == 0)
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + @"\Resources\images\montale_logo.jpg");
                        pictureBox.Name = "Montale";
                        pictureBox.MouseClick += OnPerfumeHouseClick;
                        
                    }

                    if (i == 0 && j == 1)
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + @"\Resources\images\mancera_logo.jpg");
                        pictureBox.Name = "Mancera";
                        pictureBox.MouseClick += OnPerfumeHouseClick;


                    }

                    if (i == 1 && j == 1)
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + @"\Resources\images\adi_logo.jpg");
                        pictureBox.Name = "Adi";
                        pictureBox.MouseClick += OnPerfumeHouseClick;
                    }

                    if (i == 1 && j == 0)
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + @"\Resources\images\tom_ford_logo.jpg");
                        pictureBox.Name = "TomFord";
                        pictureBox.MouseClick += OnPerfumeHouseClick;
                    }
                    if (i == 2 && j == 1)
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + @"\Resources\images\maison_margiela_logo.png");
                        pictureBox.Name = "Margiela";
                        pictureBox.MouseClick += OnPerfumeHouseClick;
                    }

                    if (i == 2 && j == 0)
                    {
                        pictureBox.Image = Image.FromFile(Application.StartupPath + @"\Resources\images\nasomatto_logo.jpg");
                        pictureBox.Name = "Nasomatto";
                        pictureBox.MouseClick += OnPerfumeHouseClick;
                    }



                    gr.Controls.Add(pictureBox);
                    tableLayoutPanel2.Controls.Add(gr, i, j);
                }

        }

        private void OnPerfumeHouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Image img = pictureBox.Image;

            switch (pictureBox.Name)
            {
                case "Montale":
                    imgIndex = 0;
                    break;
                case "Mancera":
                    imgIndex = 1;
                    break;
                case "Adi":
                    imgIndex = 2;
                    break;
                case "TomFord":
                    imgIndex = 3;
                    break;
                case "Margiela":
                    imgIndex = 4;
                    break;
                case "Nasomatto":
                    imgIndex = 5;
                    break;

            }



            switch (imgIndex)
            {
                case 0:
                    using (FragranceHouseForm fragranceHouseForm = new FragranceHouseForm(currentUser, "Montale", img))
                    {
                        this.Visible = false;
                        fragranceHouseForm.ShowDialog();
                        this.Visible = true;
                        try
                        {
                            fragranceHouseForm.Dispose();
                        }
                        catch (Exception ex) { }
                    }

                    break;

                case 1:
                    using (FragranceHouseForm fragranceHouseForm1 = new FragranceHouseForm(currentUser, "Mancera", img))
                    {
                        this.Visible = false;
                        fragranceHouseForm1.ShowDialog();
                        this.Visible = true;
                        try
                        {
                            fragranceHouseForm1.Dispose();
                        }
                        catch (Exception ex) { }
                    }

                    break;
                case 2:
                    using (FragranceHouseForm fragranceHouseForm1 = new FragranceHouseForm(currentUser, "Adi ale Van", img))
                    {
                        this.Visible = false;
                        fragranceHouseForm1.ShowDialog();
                        this.Visible = true;
                        try
                        {
                            fragranceHouseForm1.Dispose();
                        }
                        catch (Exception ex) { }
                    }

                    break;
                case 3:
                    using (FragranceHouseForm fragranceHouseForm1 = new FragranceHouseForm(currentUser, "Tom Ford", img))
                    {
                        this.Visible = false;
                        fragranceHouseForm1.ShowDialog();
                        this.Visible = true;
                        try
                        {
                            fragranceHouseForm1.Dispose();
                        }
                        catch (Exception ex) { }


                    }

                    break;

                case 4:
                    using (FragranceHouseForm fragranceHouseForm1 = new FragranceHouseForm(currentUser, "Maison Margiela", img))
                    {
                        this.Visible = false;
                        fragranceHouseForm1.ShowDialog();
                        this.Visible = true;
                        try
                        {
                            fragranceHouseForm1.Dispose();
                        }
                        catch (Exception ex) { }
                    }

                    break;
                case 5:
                    using (FragranceHouseForm fragranceHouseForm1 = new FragranceHouseForm(currentUser, "Nasomatto", img))
                    {
                        this.Visible = false;
                        fragranceHouseForm1.ShowDialog();
                        this.Visible = true;
                        try
                        {
                            fragranceHouseForm1.Dispose();
                        }
                        catch (Exception ex) { }
                    }

                    break;
            }


        }


        void OnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FontDialog fontDialog = new FontDialog();
                fontDialog.ShowDialog(this);

                if (!lblMainPageFormNickname.Font.Equals(fontDialog.Font))
                {
                    lblMainPageFormNickname.Font = fontDialog.Font;

                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("", conn))
                        {
                            cmd.CommandText = $"UPDATE Users SET UserTextFont = '{lblMainPageFormNickname.Font.FontFamily.Name}'";
                            cmd.CommandText = $"UPDATE Users SET UserFontSize = '{lblMainPageFormNickname.Font.Size}'";
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog(this);

                if (!lblMainPageFormNickname.ForeColor.Equals(colorDialog.Color))
                {
                    lblMainPageFormNickname.ForeColor = colorDialog.Color;

                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("", conn))
                        {
                            cmd.CommandText = $"UPDATE Users SET UserTextColor = '{lblMainPageFormNickname.ForeColor.Name}'";
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }

            }



        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            SetUpWishlist();
        }

        private void MainPageForm_Paint(object sender, PaintEventArgs e)
        {
            SetUpWishlist();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex) { }
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
                            Application.Exit();
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }
            }
        }
    }
}
