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
    public partial class Form7 : Form
    {
        TheclubGymcontext context = new TheclubGymcontext();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadFormData();
            dataGridView1.CellClick += dataGridView1_SelectionChanged;
            #region comboxes
            comboBox1.Items.Add("Powerlifting");
            comboBox1.Items.Add("Boxing");
            comboBox1.Items.Add("Crossfit");
            comboBox1.Items.Add("Kickboxing");
            comboBox1.Items.Add("Conditioning");


            comboBox2.Items.Add("admin");
            comboBox2.Items.Add("member");
            #endregion

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                var currentRow = dataGridView1.CurrentRow;

                textBox1.Text = currentRow.Cells["Fname"].Value?.ToString();
                textBox2.Text = currentRow.Cells["Lname"].Value?.ToString();
                textBox3.Text = currentRow.Cells["Username"].Value?.ToString();
                textBox4.Text = currentRow.Cells["Password"].Value?.ToString();
                textBox5.Text = currentRow.Cells["Email"].Value?.ToString();
                textBox6.Text = currentRow.Cells["Address"].Value?.ToString();

                if (DateTime.TryParse(currentRow.Cells["MembershipStartDate"].Value?.ToString(), out DateTime startDate))
                {
                    dateTimePicker1.Value = startDate; // Assign value to the first DateTimePicker
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now; // Default value if parsing fails
                }

                if (DateTime.TryParse(currentRow.Cells["MembershipEndDate"].Value?.ToString(), out DateTime endDate))
                {
                    dateTimePicker2.Value = endDate; // Assign value to the second DateTimePicker
                }
                else
                {
                    dateTimePicker2.Value = DateTime.Now; // Default value if parsing fails
                }

                var coachName = currentRow.Cells["Couch"].Value?.ToString(); // Retrieve the coach's name from the current row
                if (!string.IsNullOrEmpty(coachName))
                {
                    comboBox1.SelectedItem = (string)coachName;
                }
                else
                {
                    comboBox1.SelectedItem = null;
                }
                var roleName = currentRow.Cells["role"].Value?.ToString();
                if (!string.IsNullOrEmpty(roleName))
                {
                    comboBox2.SelectedItem = (string)roleName;
                }
                else
                {
                    comboBox2.SelectedItem = null;
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedid = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());


            var updateemployee = context.Members.FirstOrDefault(emp => emp.ID == selectedid);

            if (updateemployee != null)
            {

                updateemployee.Fname = textBox1.Text;
                updateemployee.Lname = textBox2.Text;
                updateemployee.Username = textBox3.Text;
                updateemployee.Password = textBox4.Text;
                updateemployee.Email = textBox5.Text;
                updateemployee.Address = textBox6.Text;
                updateemployee.MembershipStartDate = dateTimePicker1.Value;
                updateemployee.MembershipEndDate = dateTimePicker2.Value;

                context.Members.Update(updateemployee);
                MessageBox.Show("Updated successfull", "Update", MessageBoxButtons.OK);
                context.SaveChanges();
                LoadFormData();

            }
        }

        private void registerbutton1_Click(object sender, EventArgs e)
        {
            int selectedid = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());


            var updateemployee = context.Members.FirstOrDefault(emp => emp.ID == selectedid);

            if (updateemployee != null)
            {



                context.Members.Remove(updateemployee);
                MessageBox.Show("deleted successfull", "delete", MessageBoxButtons.OK);
                context.SaveChanges();
                LoadFormData();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newfname = textBox1.Text.ToLower();
            var newlname = textBox2.Text.ToLower();
            var newusername = textBox3.Text.ToLower();
            var newpass = textBox4.Text.ToLower();
            var newemail = textBox5.Text.ToLower();
            var newaddres = textBox6.Text.ToLower();
            var newstart = dateTimePicker1.Value;
            var newend = dateTimePicker2.Value;

            var newmember = new members()
            {
                Fname = newfname,
                Lname = newlname,
                Username = newusername,
                Password = newpass,
                Email = newemail,
                Address = newaddres,
                MembershipStartDate = newstart,
                MembershipEndDate = newend,
                couch = (string)comboBox1?.SelectedItem,
                role = (string)comboBox2?.SelectedItem,

            };
            context.Add(newmember);
            MessageBox.Show("Added successfull", "ADD", MessageBoxButtons.OK);
            context.SaveChanges();
            LoadFormData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var searchmember = textBox7.Text.ToLower();
            var searchedmember = context.Members.Where(s => s.Fname.ToLower().Contains(searchmember)).Select(s => new { s.ID, s.Fname, s.Lname, s.Email, s.Address, s.Age, s.MembershipStartDate, s.MembershipEndDate, s.Password, s.Username, s.couch }).ToList();
            dataGridView1.DataSource = searchedmember;
        }


        private void LoadFormData()
        {
            var allMembers = context.Members.ToList(); // Fetch all members

            dataGridView1.DataSource = allMembers; // Reload the full data
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";
            LoadFormData();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = textBox7.Text.ToLower();

            // If the search query is empty, reload the full data
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                LoadFormData(); // Call a method to reload the full data
                return;
            }

            // Perform the search dynamically
            var searchedMembers = context.Members
                .Where(s => s.Username.ToLower().Contains(searchQuery))
                .ToList();

            // Update DataGridView with the search results

            dataGridView1.DataSource = searchedMembers;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Location = this.Location;
            this.Hide();
            form1.Show();
            
        }
    }
}
