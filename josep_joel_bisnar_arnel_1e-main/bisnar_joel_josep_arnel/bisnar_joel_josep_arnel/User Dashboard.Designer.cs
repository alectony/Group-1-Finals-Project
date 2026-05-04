namespace bisnar_joel_josep_arnel
{
    partial class User_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            btnDashboard = new Button();
            panel1 = new Panel();
            btnMyprofile = new Button();
            btnProducts = new Button();
            btnMyorders = new Button();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            panel9 = new Panel();
            label12 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            listNotifications = new ListBox();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            btnlifetime = new Button();
            lblTotalspent = new Label();
            label9 = new Label();
            panel5 = new Panel();
            btnInQueue = new Button();
            lblPending = new Label();
            label6 = new Label();
            panel4 = new Panel();
            btnActive = new Button();
            lblOrder = new Label();
            label7 = new Label();
            panel3 = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            lblpanel = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            lblpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.ForeColor = Color.FromArgb(212, 175, 55);
            btnDashboard.Location = new Point(0, 27);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(208, 30);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "📊 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 60);
            panel1.Controls.Add(btnMyprofile);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnMyorders);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 350);
            panel1.TabIndex = 1;
            // 
            // btnMyprofile
            // 
            btnMyprofile.BackColor = Color.Transparent;
            btnMyprofile.FlatStyle = FlatStyle.Flat;
            btnMyprofile.Font = new Font("Segoe UI", 11F);
            btnMyprofile.ForeColor = Color.Green;
            btnMyprofile.Location = new Point(0, 166);
            btnMyprofile.Name = "btnMyprofile";
            btnMyprofile.Padding = new Padding(10, 0, 0, 0);
            btnMyprofile.Size = new Size(208, 30);
            btnMyprofile.TabIndex = 3;
            btnMyprofile.Text = "👤My Profile";
            btnMyprofile.TextAlign = ContentAlignment.MiddleLeft;
            btnMyprofile.UseVisualStyleBackColor = false;
            btnMyprofile.Click += btnMyprofile_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Transparent;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11F);
            btnProducts.ForeColor = Color.Green;
            btnProducts.Location = new Point(0, 120);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(10, 0, 0, 0);
            btnProducts.Size = new Size(208, 30);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "🛍️Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnMyorders
            // 
            btnMyorders.BackColor = Color.Transparent;
            btnMyorders.FlatStyle = FlatStyle.Flat;
            btnMyorders.Font = new Font("Segoe UI", 11F);
            btnMyorders.ForeColor = Color.Green;
            btnMyorders.Location = new Point(0, 72);
            btnMyorders.Name = "btnMyorders";
            btnMyorders.Padding = new Padding(10, 0, 0, 0);
            btnMyorders.Size = new Size(208, 30);
            btnMyorders.TabIndex = 1;
            btnMyorders.Text = "🚚My Orders";
            btnMyorders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyorders.UseVisualStyleBackColor = false;
            btnMyorders.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 136, 39);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(listNotifications);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(208, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 461);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 243, 224);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 183);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(629, 109);
            dataGridView2.TabIndex = 19;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(15, 7, 43);
            panel9.Controls.Add(label12);
            panel9.Location = new Point(6, 300);
            panel9.Name = "panel9";
            panel9.Size = new Size(650, 30);
            panel9.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 4);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 14;
            label12.Text = "NOTIFICATION";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(15, 7, 43);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(6, 153);
            panel8.Name = "panel8";
            panel8.Size = new Size(650, 24);
            panel8.TabIndex = 17;
            panel8.Paint += panel8_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(10, 2);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 12;
            label11.Text = "RECENT ORDERS";
            label11.Click += label11_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(15, 7, 43);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(652, 40);
            panel7.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 3);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 0;
            label4.Text = "DASHBOARD";
            label4.Click += label4_Click;
            // 
            // listNotifications
            // 
            listNotifications.BackColor = Color.FromArgb(227, 242, 253);
            listNotifications.BorderStyle = BorderStyle.None;
            listNotifications.ForeColor = Color.Black;
            listNotifications.FormattingEnabled = true;
            listNotifications.ItemHeight = 15;
            listNotifications.Items.AddRange(new object[] { "\U0001f7e2Order #1041 is being prepared.", "      1hours ago", "", "\U0001f7e2New promo: 10% off on beverages today.", "      3hours ago", "", "\U0001f7e2Your profile is incomplete. Please update.", "      Yesterday" });
            listNotifications.Location = new Point(18, 336);
            listNotifications.Name = "listNotifications";
            listNotifications.Size = new Size(629, 120);
            listNotifications.TabIndex = 15;
            listNotifications.SelectedIndexChanged += listNotifications_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(232, 136, 39);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(650, 111);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(227, 242, 253);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnlifetime);
            panel6.Controls.Add(lblTotalspent);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(460, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 95);
            panel6.TabIndex = 8;
            panel6.Paint += panel6_Paint;
            // 
            // btnlifetime
            // 
            btnlifetime.BackColor = Color.FromArgb(227, 242, 253);
            btnlifetime.FlatStyle = FlatStyle.Popup;
            btnlifetime.ForeColor = Color.Blue;
            btnlifetime.Location = new Point(21, 58);
            btnlifetime.Name = "btnlifetime";
            btnlifetime.Size = new Size(68, 23);
            btnlifetime.TabIndex = 14;
            btnlifetime.Text = "LifeTime";
            btnlifetime.UseVisualStyleBackColor = false;
            // 
            // lblTotalspent
            // 
            lblTotalspent.AutoSize = true;
            lblTotalspent.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalspent.ForeColor = Color.Black;
            lblTotalspent.Location = new Point(21, 27);
            lblTotalspent.Name = "lblTotalspent";
            lblTotalspent.Size = new Size(84, 28);
            lblTotalspent.TabIndex = 13;
            lblTotalspent.Text = "₱ 3,240";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(21, 14);
            label9.Name = "label9";
            label9.Size = new Size(70, 13);
            label9.TabIndex = 11;
            label9.Text = "TOTAL SPENT";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 243, 224);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnInQueue);
            panel5.Controls.Add(lblPending);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(243, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(188, 95);
            panel5.TabIndex = 8;
            panel5.Paint += panel5_Paint;
            // 
            // btnInQueue
            // 
            btnInQueue.BackColor = Color.FromArgb(255, 244, 214);
            btnInQueue.FlatStyle = FlatStyle.Flat;
            btnInQueue.ForeColor = Color.Orange;
            btnInQueue.Location = new Point(12, 58);
            btnInQueue.Name = "btnInQueue";
            btnInQueue.Size = new Size(71, 23);
            btnInQueue.TabIndex = 12;
            btnInQueue.Text = "In Queue";
            btnInQueue.UseVisualStyleBackColor = false;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPending.ForeColor = Color.Black;
            lblPending.Location = new Point(12, 27);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(24, 28);
            lblPending.TabIndex = 12;
            lblPending.Text = "2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(54, 13);
            label6.TabIndex = 10;
            label6.Text = "PENDING";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(232, 245, 233);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnActive);
            panel4.Controls.Add(lblOrder);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(18, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 95);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // btnActive
            // 
            btnActive.AutoSize = true;
            btnActive.BackColor = Color.FromArgb(223, 245, 225);
            btnActive.ForeColor = Color.Green;
            btnActive.Location = new Point(10, 58);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(53, 25);
            btnActive.TabIndex = 11;
            btnActive.Text = "Active";
            btnActive.UseVisualStyleBackColor = false;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrder.ForeColor = Color.Black;
            lblOrder.Location = new Point(10, 27);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(36, 28);
            lblOrder.TabIndex = 10;
            lblOrder.Text = "12";
            lblOrder.Click += lblOrder_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(10, 14);
            label7.Name = "label7";
            label7.Size = new Size(68, 13);
            label7.TabIndex = 9;
            label7.Text = "MY ORDERS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 28, 60);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnLogout);
            panel3.ForeColor = Color.FromArgb(28, 28, 60);
            panel3.Location = new Point(0, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 236);
            panel3.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(0, 165);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(208, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "➜]Exit ";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogout.Location = new Point(0, 129);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(208, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "➜]Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.LightGray;
            linkLabel1.LinkColor = Color.LightGray;
            linkLabel1.Location = new Point(770, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(91, 21);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "User Portal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 0;
            label1.Text = "Grab n Go";
            // 
            // lblpanel
            // 
            lblpanel.BackColor = Color.FromArgb(13, 10, 38);
            lblpanel.Controls.Add(pictureBox1);
            lblpanel.Controls.Add(label3);
            lblpanel.Controls.Add(label2);
            lblpanel.Controls.Add(linkLabel1);
            lblpanel.Controls.Add(label1);
            lblpanel.Dock = DockStyle.Top;
            lblpanel.Location = new Point(0, 0);
            lblpanel.Name = "lblpanel";
            lblpanel.Size = new Size(867, 53);
            lblpanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(720, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(1431, 22);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Juan Cruz";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(1775, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = " Juan Cruz";
            // 
            // User_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 513);
            Controls.Add(lblpanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "User_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Dashboard";
            Load += User_Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            lblpanel.ResumeLayout(false);
            lblpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDashboard;
        private Panel panel1;
        private Button btnMyorders;
        private Button btnProducts;
        private Button btnMyprofile;
        private Panel panel2;
        private Panel panel3;
        private Button btnLogout;
        private Label label4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label7;
        private Button btnActive;
        private Label lblOrder;
        private Button btnlifetime;
        private Label lblTotalspent;
        private Label label9;
        private Button btnInQueue;
        private Label lblPending;
        private Label label6;
        private Label label11;
        private DataGridView dataGridView1;
        private Label label12;
        private ListBox listNotifications;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel lblpanel;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Button btnExit;
        private DataGridView dataGridView2;
    }
}