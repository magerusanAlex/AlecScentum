using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlecScentum
{
    public partial class FragranceHouseForm : Form
    {
        User currentUser = null;
        string perfumerHouseName = "";
        Image perfumerHouseImage = null;
        List<Image> perfums = new List<Image>();
        public FragranceHouseForm(User user, string perfumerHouseName, Image image)
        {
            InitializeComponent();
            this.perfumerHouseName = perfumerHouseName;
            lblTitleFragranceHouseForm.Text = perfumerHouseName;
            currentUser = user;
            perfumerHouseImage = image;
            pictureBox1.Image = perfumerHouseImage;

            GetImagesFromFolder();
            SetupParfumeGrid();

        }

        private void GetImagesFromFolder()
        {
            string path = Application.StartupPath + @"\Resources\images\";
            perfums.Clear();

            switch (perfumerHouseName)
            {
                case "Montale":
                    perfums.Add(Image.FromFile(path + @"montale_sweet_vanilla.jpg"));
                    perfums.Add(Image.FromFile(path + @"montale_tropical_wood.jpg"));
                    perfums.Add(Image.FromFile(path + @"montale_bengal_oud.jpg"));
                    perfums.Add(Image.FromFile(path + @"montale_rendez-vous-a-paris.jpg"));


                    break;

                case "Mancera":
                    perfums.Add(Image.FromFile(path + @"mancera_aoud_lemon_mint.jpg"));
                    perfums.Add(Image.FromFile(path + @"mancera_black_gold.jpg"));
                    perfums.Add(Image.FromFile(path + @"mancera_gold_intensive_oud.jpg"));
                    perfums.Add(Image.FromFile(path + @"mancera_amore_cafe.jpg"));


                    break;

                case "Tom Ford":
                    perfums.Add(Image.FromFile(path + @"tom_ford_lost_cherry.jpg"));
                    perfums.Add(Image.FromFile(path + @"tom_ford_noir_extreme.jpg"));
                    perfums.Add(Image.FromFile(path + @"tom_ford_soleil_blanc.jpg"));
                    perfums.Add(Image.FromFile(path + @"tom_ford_azure_lime.jpg"));

                    break;

                case "Maison Margiela":
                    perfums.Add(Image.FromFile(path + @"margiela_across_sands.jpg"));
                    perfums.Add(Image.FromFile(path + @"margiela_by_the_fireplace.jpg"));
                    perfums.Add(Image.FromFile(path + @"margiela_lazy_sunday_morning.jpg"));
                    perfums.Add(Image.FromFile(path + @"margiela_mutiny.jpg"));
                    break;

                case "Nasomatto":
                    perfums.Add(Image.FromFile(path + @"nasomatto_black_afgano.jpg"));
                    perfums.Add(Image.FromFile(path + @"nasomatto_blamage.jpg"));
                    perfums.Add(Image.FromFile(path + @"nasomatto_pardon.jpg"));
                    perfums.Add(Image.FromFile(path + @"nasomatto_silver_musk.jpg"));
                    break;

                case "Adi ale Van":
                    perfums.Add(Image.FromFile(path + @"adi_hai_hui_flower.jpg"));
                    perfums.Add(Image.FromFile(path + @"adi_searching_for_faith.jpg"));
                    perfums.Add(Image.FromFile(path + @"adi_the_summer_of_83.jpg"));
                    perfums.Add(Image.FromFile(path + @"adi_umbre.jpg"));
                    break;
            }

        }

        private void SetupParfumeGrid()
        {
            pictureBox5.Image = perfums.ElementAt(0);
            pictureBox2.Image = perfums.ElementAt(1);
            pictureBox3.Image = perfums.ElementAt(2);
            pictureBox4.Image = perfums.ElementAt(3);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (perfumerHouseName)
            {
                case "Montale":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Tropical Wood - Montale"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }

                    break;
                case "Adi ale Van":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Searching for faith - Adi ale Van"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Tom Ford":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Noir Extreme Parfum - Tom Ford"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }

                    break;

                case "Maison Margiela":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "By The Fireplace - Maison Margiela"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }

                    break;

                case "Mancera":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Black Gold  - Mancera"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
                case "Nasomatto":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Balmage - Nasomatto"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (perfumerHouseName)
            {
                case "Montale":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Bengal Oud - Montale"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }

                    break;
                case "Adi ale Van":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "The Summer of 83 - Adi ale Van"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Tom Ford":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Eau de Soleil Blanc - Tom Ford"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Maison Margiela":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Lazy Sunday Morning Lunar New Year Edition - Maison Margiela"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Mancera":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Gold Intensive Aoud - Mancera"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
                case "Nasomatto":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Pardon - Nasomatto"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switch (perfumerHouseName)
            {
                case "Montale":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Sweet Vanilla - Montale"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }

                    break;
                case "Adi ale Van":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Hai Hui Flower Power Extrait - Adi ale Van"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Tom Ford":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Lost Cherry - Tom Ford"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Maison Margiela":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Across Sands - Maison Margiela"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Mancera":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Aoud Lemon Mint - Mancera"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
                case "Nasomatto":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Black Afgano - Nasomatto"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            switch (perfumerHouseName)
            {
                case "Montale":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Rendez-vous à Paris - Montale"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }

                    break;
                case "Adi ale Van":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, ".U.M.B.R.E. - Adi ale Van"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Tom Ford":

                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Azure Lime - Tom Ford"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Maison Margiela":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Mutiny - Maison Margiela"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;

                case "Mancera":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Amore Caffè - Mancera"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
                case "Nasomatto":
                    using (ParfumePresentationForm form = new ParfumePresentationForm(currentUser, "Silver Musk - Nasomatto"))
                    {
                        this.Visible = false;
                        form.ShowDialog();
                        this.Visible = true;
                    }
                    break;
            }
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
