using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheClubGymproject.Model;

namespace TheClubGymproject
{
    public partial class Form8 : Form

    {
        public int Memberid {  get; set; }

        TheclubGymcontext Context = new TheclubGymcontext();
        public Form8(int memberid )
        {
            InitializeComponent();
            Memberid = memberid;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadOffers();

        }



        private void LoadOffers()
        {
            // Example list of membership offers (can be fetched from a database)
            var offers = new List<(string Title, string Description, decimal Price)>
    {
        ("Monthly Plan", "Access to all gym facilities for one month.", 1200),
        ("3Month Plan", "Access for three months at a discounted price.", 3000),
        ("6Months Plan", "Access for three months at a discounted price.", 4500),
        ("9Months Plan", "Access for three months at a discounted price.", 6000),
        ("Yearly Plan", "Full access for one year with extra perks.", 8000),
    };

            // Clear any existing controls
            flowLayoutPanelOffers.Controls.Clear();

            foreach (var offer in offers)
            {
                // Create a panel for each offer
                Panel offerPanel = new Panel
                {
                    Width = 300,
                    Height = 150,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray
                };

                // Add a label for the title
                Label titleLabel = new Label
                {
                    Text = offer.Title,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                offerPanel.Controls.Add(titleLabel);

                // Add a label for the description
                Label descriptionLabel = new Label
                {
                    Text = offer.Description,
                    Font = new Font("Arial", 10),
                    AutoSize = false,
                    Width = 280,
                    Height = 60,
                    Location = new Point(10, 40)
                };
                offerPanel.Controls.Add(descriptionLabel);

                // Add a label for the price
                Label priceLabel = new Label
                {
                    Text = $"Price: ${offer.Price}",
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 110)
                };
                offerPanel.Controls.Add(priceLabel);

                // Add a button to select the offer
                Button selectButton = new Button
                {
                    Text = "Select",
                    Width = 80,
                    Height = 30,
                    Location = new Point(200, 110),
                    Tag = Tuple.Create(offer.Title, offer.Description, offer.Price) // Store the offer details in the button's Tag
                };
                selectButton.Click += SelectButton_Click; // Attach click event
                offerPanel.Controls.Add(selectButton);

                // Add the panel to the FlowLayoutPanel
                flowLayoutPanelOffers.Controls.Add(offerPanel);
            }
        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
           
            if (sender is Button button && button.Tag is Tuple<string, string, decimal> offer)
            {
                // Show confirmation message
                MessageBox.Show($"You selected the {offer.Item1}.\nPlease proceed to the reception to pay ${offer.Item3}.",
                                "Membership Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Optionally save the selection in the database

                //var membership = Context.Memberships.FirstOrDefault(s => s.MemberId == Memberid);
                //if (membership == null)
                //{
                //     membership = new membership
                //    {
                //        MemberId = Memberid,
                //        IsPaid = false, // Indicate payment is pending
                //        PurchaseDate = DateTime.Now,
                //        StartDate = DateTime.Now.AddYears(1), // Example, you can adjust as needed
                //        EndDate = DateTime.Now.AddYears(1),
                //    };
                //    Context.Memberships.Add(membership);
                //    Context.SaveChanges();
                //}
                //else
                //{
                //    membership.IsPaid = false;
                //}
                //var newMembership = new membership
                //{
                //    MemberId = Memberid,
                //    IsPaid = false, // Indicate payment is pending
                //    PurchaseDate = DateTime.Now,
                //    StartDate = DateTime.Now.AddDays(1), // Example, you can adjust as needed
                //    EndDate = DateTime.Now.AddYears(1),
                //};

                //Context.Memberships.Add(newMembership);
                //Context.SaveChanges();

                Form1 loginform = new Form1();
                loginform.Location = this.Location;
                this.Hide();
                loginform.Show();
            }
        }
    }
}
