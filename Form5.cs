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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheClubGymproject
{
    public partial class Form5 : Form
    {
        TheclubGymcontext Context = new TheclubGymcontext();
        public string Username { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Location = this.Location;
            form3.Username = Username;
            form3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Location = this.Location;
            form4.username = Username;
            form4.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Location = this.Location;
            form2.username = Username;
            form2.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Location = this.Location;
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Goodbye!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        
    }
}
