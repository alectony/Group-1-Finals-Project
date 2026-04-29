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
            lblpanel = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            btnDashboard = new Button();
            panel1 = new Panel();
            btnMyprofile = new Button();
            btnProducts = new Button();
            btnMyorders = new Button();
            panel2 = new Panel();
            listNotifications = new ListBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colItem = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            label11 = new Label();
            panel6 = new Panel();
            btnlifetime = new Button();
            label10 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            btnInQueue = new Button();
            label8 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            btnActive = new Button();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnLogout = new Button();
            lblpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblpanel
            // 
            lblpanel.BackColor = Color.FromArgb(47, 107, 15);
            lblpanel.Controls.Add(pictureBox1);
            lblpanel.Controls.Add(label3);
            lblpanel.Controls.Add(label2);
            lblpanel.Controls.Add(linkLabel1);
            lblpanel.Controls.Add(label1);
            lblpanel.Dock = DockStyle.Top;
            lblpanel.Location = new Point(0, 0);
            lblpanel.Name = "lblpanel";
            lblpanel.Size = new Size(885, 53);
            lblpanel.TabIndex = 0;
            lblpanel.Paint += lblpanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(837, 10);
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
            label3.Location = new Point(764, 22);
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
            label2.Location = new Point(1108, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = " Juan Cruz";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.LightGray;
            linkLabel1.LinkColor = Color.LightGray;
            linkLabel1.Location = new Point(118, 22);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "User Portal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Grab & Go";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(0, 3);
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMyprofile);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnMyorders);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 161);
            panel1.TabIndex = 1;
            // 
            // btnMyprofile
            // 
            btnMyprofile.BackColor = Color.Transparent;
            btnMyprofile.FlatStyle = FlatStyle.Flat;
            btnMyprofile.Font = new Font("Segoe UI", 11F);
            btnMyprofile.ForeColor = Color.Black;
            btnMyprofile.Location = new Point(0, 98);
            btnMyprofile.Name = "btnMyprofile";
            btnMyprofile.Padding = new Padding(10, 0, 0, 0);
            btnMyprofile.Size = new Size(208, 30);
            btnMyprofile.TabIndex = 3;
            btnMyprofile.Text = "👤My Profile";
            btnMyprofile.TextAlign = ContentAlignment.MiddleLeft;
            btnMyprofile.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.White;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11F);
            btnProducts.ForeColor = Color.Black;
            btnProducts.Location = new Point(0, 66);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(10, 0, 0, 0);
            btnProducts.Size = new Size(208, 30);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "🛍️Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnMyorders
            // 
            btnMyorders.BackColor = Color.White;
            btnMyorders.FlatStyle = FlatStyle.Flat;
            btnMyorders.Font = new Font("Segoe UI", 11F);
            btnMyorders.Location = new Point(0, 34);
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
            panel2.BackColor = Color.White;
            panel2.Controls.Add(listNotifications);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(214, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 458);
            panel2.TabIndex = 2;
            // 
            // listNotifications
            // 
            listNotifications.BackColor = Color.White;
            listNotifications.BorderStyle = BorderStyle.None;
            listNotifications.FormattingEnabled = true;
            listNotifications.ItemHeight = 15;
            listNotifications.Items.AddRange(new object[] { "\U0001f7e2Order #1041 is being prepared.", "      1hours ago", "", "\U0001f7e2New promo: 10% off on beverages today.", "      3hours ago", "", "\U0001f7e2Your profile is incomplete. Please update.", "      Yesterday" });
            listNotifications.Location = new Point(6, 313);
            listNotifications.Name = "listNotifications";
            listNotifications.Size = new Size(650, 135);
            listNotifications.TabIndex = 15;
            listNotifications.SelectedIndexChanged += listNotifications_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(16, 294);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 14;
            label12.Text = "NOTIFICATION";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colItem, colQty, colTotal, colStatus });
            dataGridView1.Location = new Point(16, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(617, 111);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colOrderId
            // 
            colOrderId.HeaderText = "ORDER ID";
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colItem
            // 
            colItem.HeaderText = "ITEM";
            colItem.Name = "colItem";
            colItem.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "QTY";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "TOTAL";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(16, 157);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 12;
            label11.Text = "RECENT ORDERS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btnlifetime);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(446, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 95);
            panel6.TabIndex = 8;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(21, 27);
            label10.Name = "label10";
            label10.Size = new Size(84, 28);
            label10.TabIndex = 13;
            label10.Text = "₱ 3,240";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(21, 14);
            label9.Name = "label9";
            label9.Size = new Size(73, 13);
            label9.TabIndex = 11;
            label9.Text = "TOTAL SPENT";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnInQueue);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(227, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(188, 95);
            panel5.TabIndex = 8;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 27);
            label8.Name = "label8";
            label8.Size = new Size(24, 28);
            label8.TabIndex = 12;
            label8.Text = "2";
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
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnActive);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(6, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 95);
            panel4.TabIndex = 7;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(10, 27);
            label5.Name = "label5";
            label5.Size = new Size(36, 28);
            label5.TabIndex = 10;
            label5.Text = "12";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(16, 11);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 0;
            label4.Text = "Hello, Juan!";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnLogout);
            panel3.Location = new Point(0, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 294);
            panel3.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(0, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(208, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "➜]Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // User_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 244);
            ClientSize = new Size(885, 517);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblpanel);
            Name = "User_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Dashboard";
            Load += User_Dashboard_Load;
            lblpanel.ResumeLayout(false);
            lblpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel lblpanel;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
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
        private PictureBox pictureBox1;
        private Button btnActive;
        private Label label5;
        private Button btnlifetime;
        private Label label10;
        private Label label9;
        private Button btnInQueue;
        private Label label8;
        private Label label6;
        private Label label11;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colItem;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colStatus;
        private Label label12;
        private ListBox listNotifications;
    }
}