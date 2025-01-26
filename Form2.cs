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

namespace TheClubGymproject
{
    public partial class Form2 : Form
    {
        TheclubGymcontext Context = new TheclubGymcontext();
        public string username { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void AddBUTTON_Click(object sender, EventArgs e)
        {

            var newmember = new members()
            {

                Fname = textBox8.Text,
                Lname = textBox7.Text,
                Username = textBox4.Text,
                Password = textBox3.Text,
                Age = int.Parse(textBox2.Text),
                Address = textBox1.Text,
                Email = textBox6.Text,
                MembershipStartDate = dateTimePicker2.Value,
                MembershipEndDate = dateTimePicker1.Value,
            };

            Context.Members.Add(newmember);
            Context.SaveChanges();
            MessageBox.Show("Your're Now part of the family", "REGISTER TO THECLUBGYM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Form1 LOGINForm = new Form1();
            LOGINForm.Location = this.Location;
            this.Hide();
            LOGINForm.ShowDialog();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox3.UseSystemPasswordChar = false;

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Location = this.Location;
            form5.Show();
            this.Hide();
        }


        //private void button1delete_Click(object sender, EventArgs e)
        //{
        //    int selectedid = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());


        //    var updatedmember = Context.Members.FirstOrDefault(s => s.ID == selectedid);

        //    if (updatedmember != null)
        //    {

        //        Context.Members.Remove(updatedmember);
        //        //MessageBox.Show("Updated successfull", "Update", MessageBoxButtons.OK);
        //        Context.SaveChanges();


        //        //Formload();
        //    }

        //}

        //private void update_Click_1(object sender, EventArgs e)
        //{
        //    int selectedid = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());


        //    var updatedmember = Context.Members.FirstOrDefault(s => s.ID == selectedid);

        //    if (updatedmember != null)
        //    {

        //        updatedmember.Fname = textBox8.Text;
        //        updatedmember.Lname = textBox7.Text;
        //        updatedmember.Username = textBox4.Text;
        //        updatedmember.Password = textBox3.Text;
        //        updatedmember.MembershipStartDate = dateTimePicker2.Value;
        //        updatedmember.MembershipEndDate = dateTimePicker1.Value;
        //        updatedmember.Age = int.Parse(textBox2.Text);
        //        updatedmember.Address = textBox1.Text;
        //        updatedmember.Email = textBox6.Text;


        //        Context.Members.Update(updatedmember);
        //        MessageBox.Show("Updated successfull", "Update", MessageBoxButtons.OK);
        //        Context.SaveChanges();


        //        //Formload();
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.ClearSelection();
        //    Formload();
        //    textBox1.Text = " ";
        //    textBox2.Text = " ";
        //    textBox3.Text = " ";
        //    textBox4.Text = " ";
        //    textBox8.Text = " ";
        //    textBox7.Text = " ";
        //    textBox6.Text = " ";

        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            var username = textBox4.Text;
            if (!string.IsNullOrEmpty(username))
            {
                var existingMember = Context.Members.FirstOrDefault(m => m.Username == username);
                if (existingMember != null)
                {
                    MessageBox.Show("This username is already taken. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    textBox4.SelectAll();
                }
            }
        }
    }
}
