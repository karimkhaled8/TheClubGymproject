using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using TheClubGymproject.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheClubGymproject
{
    public partial class Form4 : Form
    {
        TheclubGymcontext Context = new TheclubGymcontext();
        private readonly TheclubGymcontext _context;
        public string username { get; set; }
        public Form4()
        {
            InitializeComponent();
            _context = new TheclubGymcontext();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var coaches = Context.trainers.Select(s => new { s.Id, s.Fname, s.Lname, s.Specialaiztion, s.phonenumber }).ToList();
            //dataGridView1.DataSource = coaches;


            PopulateFlowLayoutPanel();
            LoadChart();
            #region comboboxes


            var pt1 = Context.trainers.Select(s => new { s.Id, s.Specialaiztion }).ToList();
            comboBox2.DataSource = pt1;
            comboBox2.DisplayMember = "Specialaiztion";
            comboBox2.ValueMember = "Specialaiztion";
            #endregion


        }
        private void LoadChart()
        {

            // Get total members in the gym and members in classes
            var totalMembers = _context.Members.Count();

            // Group members by coach and count the number of members for each coach
            var coachCounts = _context.Members
                .GroupBy(m => m.couch)
                .Select(g => new
                {
                    Coach = g.Key ?? "No Coach Assigned", // Handle null values for coaches
                    MemberCount = g.Count()
                })
                .ToList();

            // Prepare data for the chart
            SeriesCollection series = new SeriesCollection();


            // Add each coach's percentage to the pie chart
            foreach (var coachInfo in coachCounts)
            {
                if (totalMembers > 0) // Avoid division by zero
                {
                    double percentage = (coachInfo.MemberCount / (double)totalMembers) * 100;

                    series.Add(new PieSeries
                    {
                        Title = $"{coachInfo.Coach} ({percentage:f1}%)", // Fixed percentage without decimals
                        Values = new ChartValues<double> { percentage },
                        DataLabels = true,
                        LabelPoint = chartPoint => $"{percentage:f1}%",
                        FontSize = 10,

                    });
                }
            }

            // Configure the chart
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Right;

            // Optional: Add a title to the chart
            pieChart1.InnerRadius = 17.5;

        }
        private void PopulateFlowLayoutPanel()
        {
            // Fetch data
            var coaches = Context.trainers.Select(s => new
            {
                s.Id,
                s.Fname,
                s.Lname,
                s.Specialaiztion,
                s.phonenumber
            }).ToList();

            // Clear any existing controls
            flowLayoutPanel1.Controls.Clear();

            // Loop through each coach and create a card
            foreach (var coach in coaches)
            {
                // Create a card panel
                Panel coachCard = new Panel
                {
                    Size = new Size(250, 150), // Adjust card size
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10) // Space between cards
                };

                // Create labels for details
                Label nameLabel = new Label
                {
                    Text = $" {coach.Fname} {coach.Lname}",
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label specializationLabel = new Label
                {
                    Text = $"Specialization: {coach.Specialaiztion}",
                    Font = new Font("Arial", 12),
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                Label phoneLabel = new Label
                {
                    Text = $"Phone: {coach.phonenumber}",
                    Font = new Font("Arial", 9),
                    Location = new Point(10, 70),
                    AutoSize = true
                };

                // Add labels to the card
                coachCard.Controls.Add(nameLabel);
                coachCard.Controls.Add(specializationLabel);
                coachCard.Controls.Add(phoneLabel);

                // Add the card to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(coachCard);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var updatedmember = Context.Members.FirstOrDefault(s => s.Username == username);

            if (updatedmember != null)
            {

                updatedmember.couch = (string)comboBox2.SelectedValue;



                Context.Members.Update(updatedmember);
                MessageBox.Show("Updated successfull", "Update", MessageBoxButtons.OK);
                Context.SaveChanges();

                var coaches = Context.trainers.Select(s => new { s.Id, s.Fname, s.Lname, s.Specialaiztion, s.phonenumber }).ToList();
                //dataGridView1.DataSource = coaches;

                var loginuser = Context.Members.Where(s => s.Username == username).Select(s => new { s.ID, s.Username, s.Password, s.Fname, s.MembershipStartDate, s.MembershipEndDate, s.couch, s.Age, s.Email }).ToList();



                Form3 form3 = new Form3();
                form3.Location=this.Location;
                form3.Username = username;
                this.Hide();
                form3.Show();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Location=this.Location;
            form5.Username = username;
            this.Hide();
            form5.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pieChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}

