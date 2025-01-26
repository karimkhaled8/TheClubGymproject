namespace TheClubGymproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            registerbutton1 = new Button();
            label2 = new Label();
            loginbutton1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(397, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(636, 567);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(registerbutton1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(loginbutton1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 567);
            panel1.TabIndex = 3;
            // 
            // registerbutton1
            // 
            registerbutton1.BackColor = Color.DarkRed;
            registerbutton1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            registerbutton1.ForeColor = Color.White;
            registerbutton1.Location = new Point(201, 454);
            registerbutton1.Name = "registerbutton1";
            registerbutton1.Size = new Size(158, 39);
            registerbutton1.TabIndex = 6;
            registerbutton1.Text = "Register";
            registerbutton1.UseVisualStyleBackColor = false;
            registerbutton1.Click += registerbutton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 412);
            label2.Name = "label2";
            label2.Size = new Size(184, 26);
            label2.TabIndex = 5;
            label2.Text = "Forget Password?";
            // 
            // loginbutton1
            // 
            loginbutton1.BackColor = Color.DarkRed;
            loginbutton1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginbutton1.ForeColor = Color.White;
            loginbutton1.Location = new Point(69, 359);
            loginbutton1.Name = "loginbutton1";
            loginbutton1.Size = new Size(256, 50);
            loginbutton1.TabIndex = 4;
            loginbutton1.Text = "LOGIN";
            loginbutton1.UseVisualStyleBackColor = false;
            loginbutton1.Click += loginbutton1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InfoText;
            textBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Beige;
            textBox2.Location = new Point(69, 169);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your MemberID";
            textBox2.Size = new Size(274, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(69, 258);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your password";
            textBox1.Size = new Size(274, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 64);
            label1.Name = "label1";
            label1.Size = new Size(221, 34);
            label1.TabIndex = 1;
            label1.Text = "  LOGIN FORM  ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 454);
            button1.Name = "button1";
            button1.Size = new Size(158, 39);
            button1.TabIndex = 7;
            button1.Text = "Renew  ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1030, 563);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button loginbutton1;
        private Label label2;
        private Button registerbutton1;
        private Button button1;
    }
}
