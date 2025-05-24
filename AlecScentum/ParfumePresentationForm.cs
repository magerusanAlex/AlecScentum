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

namespace AlecScentum
{
    public partial class ParfumePresentationForm : Form
    {
        User currentUser = new User();
        string fragranceName = "";
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AlecScentumDB.mdf;Integrated Security=True;Connect Timeout=30";
        public ParfumePresentationForm(User currentUser, string fragranceName)
        {
            InitializeComponent();
            this.fragranceName = fragranceName;
            this.currentUser = currentUser;
            SetupPictureBox();
        }

        private void SetupPictureBox()
        {
            string path = Application.StartupPath + @"\Resources\images\";
            switch (fragranceName)
            {
                case "The Summer of 83 - Adi ale Van":
                    pictureBox1.Image = Image.FromFile(path + @"adi_the_summer_of_83_presentation.png");
                    richTextBox1.Text = "The Summer of 83 - Memories Potion by Adi Ale Van is a fragrance for women and men. This is a new fragrance. The Summer of 83 - Memories Potion was launched in 2023. The nose behind this fragrance is Jimmy Bodin. Top notes are Yuzu and Mushroom; middle notes are Lavender, Woody Notes and Tobacco Leaf; base notes are Violet Leaf, Indonesian Patchouli Leaf and Soil Tincture.";
                    break;
                case "Bengal Oud - Montale":
                    richTextBox1.Text = "Bengal Oud by Montale is a Woody Floral Musk fragrance for women and men. Bengal Oud was launched in 2019. Top notes are Agarwood (Oud), Bitter Orange and Bergamot; middle notes are Leather, Bulgarian Rose, Iris, Patchouli and Egyptian Jasmine; base notes are Haitian Vetiver, White Musk, Sandalwood, Cedar and Amber.";
                    pictureBox1.Image = Image.FromFile(path + @"montale_bengal_oud_presentation.png");
                    break;
                case "Eau de Soleil Blanc - Tom Ford":
                    richTextBox1.Text = "Eau de Soleil Blanc by Tom Ford is a Amber Floral fragrance for women and men. Eau de Soleil Blanc was launched in 2018. Top notes are Bitter Orange, Neroli, Bergamot, Citron, Pistachio, Petitgrain, Cardamom, Pink Pepper and Caraway; middle notes are Tuberose, Tunisian Orange Blossom, Ylang-Ylang, Jasmine and Galbanum; base notes are Coconut, Vanilla, Tonka Bean, Benzoin and Amber.";
                    pictureBox1.Image = Image.FromFile(path + @"tom_ford_soleil_blanc_presentation.png");
                    break;
                case "Gold Intensive Aoud - Mancera":
                    pictureBox1.Image = Image.FromFile(path + @"mancera_gold_intensive_oud_presentation.png");
                    richTextBox1.Text = "Gold Intensive Aoud by Mancera is a Amber Floral fragrance for women and men. Gold Intensive Aoud was launched in 2008. The nose behind this fragrance is Pierre Montale. Top notes are Lemon and Water Notes; middle notes are Rose, Guaiac Wood, Teak Wood, Saffron and Geranium; base notes are Precious Woods, White Musk and Ambergris.";
                    break;
                case "Lazy Sunday Morning Lunar New Year Edition - Maison Margiela":
                    pictureBox1.Image = Image.FromFile(path + @"margiela_lazy_sunday_morning_presentatiom.png");
                    richTextBox1.Text = "Lazy Sunday Morning Lunar New Year Edition by Maison Martin Margiela is a Floral Woody Musk fragrance for women and men. Lazy Sunday Morning Lunar New Year Edition was launched in 2021. The nose behind this fragrance is Louise Turner. Top notes are Aldehydes, Pear and Lily-of-the-Valley; middle notes are Rose, Orange Blossom and Iris; base notes are White Musk, Ambrette (Musk Mallow) and Indonesian Patchouli Leaf.";
                    break;
                case "Pardon - Nasomatto":
                    pictureBox1.Image = Image.FromFile(path + @"nasomatto_pardon_presentation.png");
                    richTextBox1.Text = "Pardon by Nasomatto is a fragrance for men. Pardon was launched in 2011. The nose behind this fragrance is Alessandro Gualtieri. Top notes are Magnolia and Flowers; middle notes are Dark Chocolate, Tonka Bean and Cinnamon; base notes are Agarwood (Oud) and Sandalwood.";
                    break;
                case "Tropical Wood - Montale":
                    pictureBox1.Image = Image.FromFile(path + @"montale_tropical_wood_presentation.png");
                    richTextBox1.Text = "Tropical Wood by Montale is a Woody Floral Musk fragrance for women and men. Tropical Wood was launched in 2016. The nose behind this fragrance is Pierre Montale. Top notes are Passionfruit, Agarwood (Oud), Pineapple and Bergamot; middle notes are Bulgarian Rose and Violet; base notes are Leather, White Musk and Madagascar Vanilla.";
                    break;
                case "Noir Extreme Parfum - Tom Ford":
                    pictureBox1.Image = Image.FromFile(path + @"tom_ford_noir_extreme_presentation.png");
                    richTextBox1.Text = "Noir Extreme Parfum by Tom Ford is a Amber Vanilla fragrance for men. This is a new fragrance. Noir Extreme Parfum was launched in 2022. Top notes are Cardamom, Ginger, Mandarin Orange, Neroli and Citruses; middle notes are Kulfi, Bulgarian Rose, Orange Blossom and Jasmine; base notes are Vanilla, Leather, Suede, Amber, Guaiac Wood, Tonka Bean and Cedar.";
                    break;
                case "Black Gold  - Mancera":
                    pictureBox1.Image = Image.FromFile(path + @"mancera_black_gold_presentation.png");
                    richTextBox1.Text = "Black Gold by Mancera is a Leather fragrance for men. Black Gold was launched in 2017. The nose behind this fragrance is Pierre Montale. Top notes are Lavender, Cinnamon, Nutmeg, Citruses and Agarwood (Oud); middle notes are Violet, Jasmine, Patchouli Leaf, Rose and Sea Notes; base notes are Leather, Woody Notes, White Musk, Amber and Vetiver.";
                    break;
                case "Balmage - Nasomatto":
                    pictureBox1.Image = Image.FromFile(path + @"nasomatto_blamage_presentation.png");
                    richTextBox1.Text = "Blamage by Nasomatto is a fragrance for women and men. Blamage was launched in 2014. The nose behind this fragrance is Alessandro Gualtieri.";
                    break;
                case "Searching for faith - Adi ale Van":
                    pictureBox1.Image = Image.FromFile(path + @"adi_searching_for_faith_presenation.png");
                    richTextBox1.Text = "Searching for faith - rare elixir by Adi Ale Van is a fragrance for women and men. This is a new fragrance. Searching for faith - rare elixir was launched in 2023. The nose behind this fragrance is Adi ale Van.";
                    break;
                case "By The Fireplace - Maison Margiela":
                    pictureBox1.Image = Image.FromFile(path + @"margiela_by_the_fireplace_presentation.png");
                    richTextBox1.Text = "By the Fireplace by Maison Martin Margiela is a Woody fragrance for women and men. By the Fireplace was launched in 2015. The nose behind this fragrance is Marie Salamagne. Top notes are Cloves, Pink Pepper and Orange Blossom; middle notes are Chestnut, Guaiac Wood and Juniper; base notes are Vanilla, Peru Balsam and Cashmeran.";
                    break;
                case "Lost Cherry - Tom Ford":
                    pictureBox1.Image = Image.FromFile(path + @"tom_ford_lost_cherry_presentation.png");
                    richTextBox1.Text = "Lost Cherry by Tom Ford is a Amber Floral fragrance for women and men. Lost Cherry was launched in 2018. The nose behind this fragrance is Louise Turner. Top notes are Bitter Almond, Black Cherry and Cherry Liqueur; middle notes are Sour Cherry, Plum, Turkish Rose and Jasmine Sambac; base notes are Vanilla, Tonka Bean, Cinnamon, Peru Balsam, Benzoin, Sandalwood, Cloves, Cedar, Patchouli and Vetiver.";
                    break;
                case "Sweet Vanilla - Montale":
                    pictureBox1.Image = Image.FromFile(path + @"montale_sweet_vanilla_presentation.png");
                    richTextBox1.Text = "Sweet Vanilla by Montale is a fragrance for women and men. Sweet Vanilla was launched in 2015. The nose behind this fragrance is Pierre Montale.";
                    break;
                case "Aoud Lemon Mint - Mancera":
                    pictureBox1.Image = Image.FromFile(path + @"mancera_aoud_lemon_mint_presentation.png");
                    richTextBox1.Text = "Aoud Lemon Mint by Mancera is a Woody Aromatic fragrance for women and men. Aoud Lemon Mint was launched in 2016. The nose behind this fragrance is Pierre Montale. Top notes are Lemon, Almond, Black Pepper and Coriander; middle notes are Agarwood (Oud), Patchouli, Egyptian Jasmine and Mint; base notes are Vanilla, White Musk, Amber, Leather and Vetiver.";
                    break;
                case "Black Afgano - Nasomatto":
                    pictureBox1.Image = Image.FromFile(path + @"nasomatto_black_afgano_presenation.png");
                    richTextBox1.Text = "Black Afgano by Nasomatto is a Woody Aromatic fragrance for women and men. The nose behind this fragrance is Alessandro Gualtieri. Top notes are cannabis and Green Notes; middle notes are Resins, Woodsy Notes, Tobacco and Coffee; base notes are Agarwood (Oud) and Incense.";
                    break;
                case "Across Sands - Maison Margiela":
                    pictureBox1.Image = Image.FromFile(path + @"margiela_across_sands_presentation.png");
                    richTextBox1.Text = "Across Sands by Maison Martin Margiela is a Woody Spicy fragrance for women and men. Across Sands was launched in 2016.";
                    break;
                case "Hai Hui Flower Power Extrait - Adi ale Van":
                    pictureBox1.Image = Image.FromFile(path + @"adi_hai_hui_flower_presentation.png");
                    richTextBox1.Text = "Hai Hui Flower Power Extrait by Adi Ale Van is a fragrance for women and men. This is a new fragrance. Hai Hui Flower Power Extrait was launched in 2022. The nose behind this fragrance is Anne-Sophie Behaghel. Top notes are Mint, Cardamom, Black Pepper and Pineapple; middle notes are elemi, Fig and Almond; base notes are Vetiver, Papyrus and Woody Notes.";
                    break;
                case "Silver Musk - Nasomatto":
                    pictureBox1.Image = Image.FromFile(path + @"nasomatto_silver_musk_presentation.png");
                    richTextBox1.Text = "Silver Musk by Nasomatto is a Amber fragrance for women and men. The nose behind this fragrance is Alessandro Gualtieri.";
                    break;
                case "Azure Lime - Tom Ford":
                    pictureBox1.Image = Image.FromFile(path + @"tom_ford_azure_lime_presentation.png");
                    richTextBox1.Text = "Azure Lime by Tom Ford is a Floral Woody Musk fragrance for women and men. Azure Lime was launched in 2010. Azure Lime was created by Antoine Lie and Ellen Molner.";
                    break;
                case "Mutiny - Maison Margiela":
                    pictureBox1.Image = Image.FromFile(path + @"margiela_mutiny_presentation.png");
                    richTextBox1.Text = "Mutiny by Maison Martin Margiela is a Amber Floral fragrance for women and men. Mutiny was launched in 2018. The nose behind this fragrance is Dominique Ropion. Top notes are Orange and Mandarin Orange; middle notes are Tuberose, Pear, Peach, Orange Blossom, Apple, Pink Pepper and Saffron; base notes are Vanilla, Leather, Patchouli and Agarwood (Oud).";
                    break;
                case ".U.M.B.R.E. - Adi ale Van":
                    pictureBox1.Image = Image.FromFile(path + @"adi_umbre_presentation.png");
                    richTextBox1.Text = ".U.M.B.R.E. by Adi Ale Van is a fragrance for women and men. .U.M.B.R.E. was launched in 2021. The nose behind this fragrance is Jimmy Bodin. Top notes are Animal notes and Davana; middle notes are Coffee, Benzoin and Cypriol Oil or Nagarmotha; base notes are Myrrh and Tobacco.";
                    break;
                case "Rendez-vous à Paris - Montale":
                    richTextBox1.Text = "Rendez-vous à Paris by Montale is a Amber Floral fragrance for women and men. This is a new fragrance. Rendez-vous à Paris was launched in 2023. The nose behind this fragrance is Pierre Montale. Top notes are Pear and Rhubarb; middle notes are Rose Petals, Patchouli, White Flowers and Ginger; base notes are Musk, Sugar, Vanilla, Powdery Notes and Ambergris.";
                    pictureBox1.Image = Image.FromFile(path + @"montale_rendez-vous-a-paris_presentation.png");
                    break;
                case "Amore Caffè - Mancera":
                    pictureBox1.Image = Image.FromFile(path + @"mancera_amore_cafe_presentation.png");
                    richTextBox1.Text = "Amore Caffè by Mancera is a fragrance for women and men. This is a new fragrance. Amore Caffè was launched in 2023. Top notes are Coffee and Amaretto; middle notes are Ice cream and Vanilla; base notes are Brown sugar, Vanilla and Ambergris.";
                    break;

            }
        }

        private void btnAddToWishList_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    cmd.CommandText = $"INSERT INTO Wishlist (UserID, FragranceName) VALUES ('{StartAppForm.UserID}', '{fragranceName}')";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }

        private void btnRemoveFromWishlist_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("", conn))
                {
                    cmd.CommandText = $"DELETE FROM Wishlist WHERE UserID='{StartAppForm.UserID}' AND FragranceName='{fragranceName}'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }catch(Exception ex) { }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
