using TheClubGymproject.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheClubGymproject
{
    public partial class Form1 : Form
    {

        TheclubGymcontext Context = new TheclubGymcontext();

     
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            var username = textBox2.Text;
            var password = textBox1.Text;
            

            //var userexist = Context.Members.Any(s => s.Username == username && s.Password == password);
            var user = Context.Members.FirstOrDefault(s => s.Username == username && s.Password == password);
            if (user != null)
            {
                if (user.MembershipEndDate < DateTime.Now)
                {
                    MessageBox.Show("Sorry your Membership Ended","membership Expired",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Show();

                }
                //MessageBox.Show("LET'S GO", "Welcome Back TO THECLUBGYM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (user.role == "admin")
                {
                    Form7 adminform = new Form7();
                    adminform.Location = this.Location;
                    adminform.Show();
                    this.Hide();
                }

                else
                {
                    Form5 form5 = new Form5();
                    form5.Location = this.Location;
                    form5.Username = username;
                    form5.Show();
                    this.Hide();
                }
               
                 
            }
            else
            {

                MessageBox.Show("Invalid username or passwrod . Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerbutton1_Click(object sender, EventArgs e)
        {
            Form2 registrationForm = new Form2();
            //registrationForm.Size=this.Size;
            registrationForm.Location = this.Location;
            registrationForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Hide();
            textBox1.PasswordChar = '*';
            textBox1.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = Context.Members.FirstOrDefault(s => s.Username == textBox2.Text && s.Password == textBox1.Text);

            if (user != null)
            {
                // Assuming you want to pass the MemberId to Form8
                Form8 offersForm = new Form8(user.ID); // Or use offersForm.MemberId = user.MemberId if using property
                offersForm.Location = this.Location;
                this.Hide();
                offersForm.Show();
            }
        }
    }
}
