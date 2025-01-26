namespace TheClubGymproject
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            flowLayoutPanelOffers = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelOffers
            // 
            flowLayoutPanelOffers.AutoScroll = true;
            flowLayoutPanelOffers.BackgroundImage = (Image)resources.GetObject("flowLayoutPanelOffers.BackgroundImage");
            flowLayoutPanelOffers.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanelOffers.Dock = DockStyle.Fill;
            flowLayoutPanelOffers.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            flowLayoutPanelOffers.Location = new Point(0, 0);
            flowLayoutPanelOffers.Name = "flowLayoutPanelOffers";
            flowLayoutPanelOffers.Size = new Size(927, 465);
            flowLayoutPanelOffers.TabIndex = 0;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 465);
            Controls.Add(flowLayoutPanelOffers);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelOffers;
    }
}