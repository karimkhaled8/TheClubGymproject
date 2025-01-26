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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheClubGymproject
{
    public partial class Form3 : Form
    {
        TheclubGymcontext Context = new TheclubGymcontext();
        public string Username { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        public void Formload()
        {
            //var members = Context.Members.Select(s => new { s.ID, s.Fname, s.Lname, s.Username, s.Password, s.MembershipStartDate, s.MembershipEndDate, s.Age, s.Address, s.Email }).ToList();
            //dataGridView1.DataSource = members;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Padding = new Padding(0, 100, 0, 0);
          

            var loginuser = Context.Members.Where(s => s.Username == Username).Select(s => new { s.ID, s.Username, s.Password, s.Fname, s.Lname,s.MembershipStartDate, s.MembershipEndDate, s.couch, s.Age, s.Email }).ToList().FirstOrDefault(); ;

            if (loginuser != null)
            {
                // Clear any existing controls in the FlowLayoutPanel
                flowLayoutPanel1.Controls.Clear();

                // Add dynamic info panels
                AddInfoCard("First Name", loginuser.Fname);
                AddInfoCard("Last Name", loginuser.Lname);
                AddInfoCard("Age", loginuser.Age.ToString());
                AddInfoCard("Email", loginuser.Email);
                AddInfoCard("Membership Start", loginuser.MembershipStartDate.ToShortDateString());
                AddInfoCard("Membership End", loginuser.MembershipEndDate.ToShortDateString());
                AddInfoCard("Coach", loginuser.couch);
                AddInfoCard("Username", loginuser.Username);
            }
            else
            {
                MessageBox.Show("User not found!");
            }

            #region panel
            //if (loginuser != null)
            //{
            //    // Clear any existing controls in the panel
            //    panelUserInfo.Controls.Clear();

            //    // Dynamically create labels for each property
            //    AddInfoLabel(panelUserInfo, "First Name", loginuser.Fname, 10);
            //    AddInfoLabel(panelUserInfo, "Last Name", loginuser.Lname, 40);
            //    AddInfoLabel(panelUserInfo, "Age", loginuser.Age.ToString(), 70);
            //    AddInfoLabel(panelUserInfo, "Email", loginuser.Email, 100);
            //    AddInfoLabel(panelUserInfo, "Membership Start", loginuser.MembershipStartDate.ToShortDateString(), 130);
            //    AddInfoLabel(panelUserInfo, "Membership End", loginuser.MembershipEndDate.ToShortDateString(), 160);
            //    AddInfoLabel(panelUserInfo, "Coach", loginuser.couch, 190);
            //    AddInfoLabel(panelUserInfo, "Username", loginuser.Username, 220);
            //}
            //else
            //{
            //    MessageBox.Show("User not found!");
            //} 
            //private void AddInfoLabel(Panel panel, string labelTitle, string labelValue, int topPosition)
            //{
            //    // Title label
            //    Label titleLabel = new Label
            //    {
            //        Text = $"{labelTitle}:",
            //        Font = new Font("Arial", 10, FontStyle.Bold),
            //        Location = new Point(10, topPosition),
            //        AutoSize = true
            //    };

            //    // Value label
            //    Label valueLabel = new Label
            //    {
            //        Text = labelValue,
            //        Font = new Font("Arial", 10),
            //        Location = new Point(150, topPosition),
            //        AutoSize = true
            //    };

            //    // Add labels to the panel
            //    panel.Controls.Add(titleLabel);
            //    panel.Controls.Add(valueLabel);
            //}
            #endregion
            #region textboxes

            //if (loginuser != null)
            //{

            //    textBox1.Text = loginuser.Fname;
            //    textBox2.Text = loginuser.Lname;
            //    textBox3.Text = loginuser.Age.ToString();
            //    textBox4.Text = loginuser.Email;
            //    textBox5.Text = loginuser.MembershipStartDate.ToShortDateString();
            //    textBox6.Text = loginuser.MembershipEndDate.ToShortDateString();
            //    textBox7.Text = loginuser.couch;
            //    textBox8.Text = loginuser.Username; 


            //}
            //else
            //{
            //    MessageBox.Show("User not found!");
            //} 
            #endregion
            //dataGridView1.CellClick += dataGridView1_SelectionChanged;
        }

        private void AddInfoCard(string title, string value)
        {
            // Create a card panel
            Panel card = new Panel
            {
                Size = new Size(200, 100), // Adjust card size
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10) // Spacing between cards
            };

            // Title Label
            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Value Label
            Label valueLabel = new Label
            {
                Text = value,
                Font = new Font("Arial", 10),
                Location = new Point(10, 40),
                AutoSize = true
            };

            // Add labels to the card
            card.Controls.Add(titleLabel);
            card.Controls.Add(valueLabel);

            // Add card to the FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(card);
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Username = Username;
            form5.Location=this.Location;
            form5.Show();
            this.Hide();
        }
      
    }
}
