namespace TheClubGymproject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button2 = new Button();
            comboBox2 = new ComboBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pieChart1 = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(282, 38);
            button2.TabIndex = 3;
            button2.Text = "TIME TO TRAIN ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(271, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 28);
            comboBox2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-4, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(521, 456);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(889, 392);
            button3.Name = "button3";
            button3.Size = new Size(282, 46);
            button3.TabIndex = 10;
            button3.Text = "Back To Home Page";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 50);
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.Location = new Point(546, -2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(631, 456);
            flowLayoutPanel1.TabIndex = 11;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.Transparent;
            pieChart1.BackgroundImage = (Image)resources.GetObject("pieChart1.BackgroundImage");
            pieChart1.BackgroundImageLayout = ImageLayout.Stretch;
            pieChart1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pieChart1.ForeColor = Color.Red;
            pieChart1.Location = new Point(-4, 1);
            pieChart1.Margin = new Padding(10, 10, 10, 30);
            pieChart1.MinimumSize = new Size(10, 10);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(550, 453);
            pieChart1.TabIndex = 12;
            pieChart1.Text = "pieChart1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 450);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(pieChart1);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.White;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private ComboBox comboBox2;
        private PictureBox pictureBox2;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}