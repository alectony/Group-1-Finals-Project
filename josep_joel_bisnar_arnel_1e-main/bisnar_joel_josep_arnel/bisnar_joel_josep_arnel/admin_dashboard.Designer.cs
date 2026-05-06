namespace bisnar_joel_josep_arnel
{
    partial class admin_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_dashboard));
            org = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            btnlifetime = new Button();
            lblTransactions = new Label();
            label9 = new Label();
            panel5 = new Panel();
            btnInQueue = new Button();
            lblStock = new Label();
            label6 = new Label();
            panel4 = new Panel();
            btnActive = new Button();
            lblTotalSales = new Label();
            label7 = new Label();
            lblpanel = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panel3 = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            btnProducts = new Button();
            btnMyorders = new Button();
            btnDashboard = new Button();
            dataGridView1 = new DataGridView();
            org.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            lblpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // org
            // 
            org.BackgroundImage = (Image)resources.GetObject("org.BackgroundImage");
            org.BackgroundImageLayout = ImageLayout.Stretch;
            org.Controls.Add(dataGridView1);
            org.Controls.Add(panel7);
            org.Controls.Add(panel6);
            org.Controls.Add(panel5);
            org.Controls.Add(panel4);
            org.Location = new Point(207, 53);
            org.Name = "org";
            org.Size = new Size(664, 433);
            org.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(15, 7, 43);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(652, 40);
            panel7.TabIndex = 20;
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
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(227, 242, 253);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnlifetime);
            panel6.Controls.Add(lblTransactions);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(459, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 95);
            panel6.TabIndex = 18;
            // 
            // btnlifetime
            // 
            btnlifetime.BackColor = Color.FromArgb(227, 242, 253);
            btnlifetime.Enabled = false;
            btnlifetime.ForeColor = Color.Green;
            btnlifetime.Location = new Point(21, 58);
            btnlifetime.Name = "btnlifetime";
            btnlifetime.Size = new Size(68, 23);
            btnlifetime.TabIndex = 14;
            btnlifetime.Text = "▲ 12%";
            btnlifetime.UseVisualStyleBackColor = false;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.ForeColor = Color.Black;
            lblTransactions.Location = new Point(19, 27);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(24, 28);
            lblTransactions.TabIndex = 13;
            lblTransactions.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(21, 14);
            label9.Name = "label9";
            label9.Size = new Size(71, 13);
            label9.TabIndex = 11;
            label9.Text = "Transactions";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 243, 224);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnInQueue);
            panel5.Controls.Add(lblStock);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(242, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(188, 95);
            panel5.TabIndex = 19;
            panel5.Paint += panel5_Paint;
            // 
            // btnInQueue
            // 
            btnInQueue.BackColor = Color.FromArgb(255, 244, 214);
            btnInQueue.Enabled = false;
            btnInQueue.ForeColor = Color.Red;
            btnInQueue.Location = new Point(12, 58);
            btnInQueue.Name = "btnInQueue";
            btnInQueue.Size = new Size(71, 23);
            btnInQueue.TabIndex = 12;
            btnInQueue.Text = "▼ 3 low";
            btnInQueue.UseVisualStyleBackColor = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(12, 27);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(24, 28);
            lblStock.TabIndex = 12;
            lblStock.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(78, 13);
            label6.TabIndex = 10;
            label6.Text = "Items in Stock";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(232, 245, 233);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnActive);
            panel4.Controls.Add(lblTotalSales);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(17, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 95);
            panel4.TabIndex = 17;
            panel4.Paint += panel4_Paint;
            // 
            // btnActive
            // 
            btnActive.AutoSize = true;
            btnActive.BackColor = Color.FromArgb(223, 245, 225);
            btnActive.Enabled = false;
            btnActive.ForeColor = Color.Green;
            btnActive.Location = new Point(10, 58);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(55, 25);
            btnActive.TabIndex = 11;
            btnActive.Text = "▲ 8.2%";
            btnActive.UseVisualStyleBackColor = false;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(10, 27);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(24, 28);
            lblTotalSales.TabIndex = 10;
            lblTotalSales.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(10, 14);
            label7.Name = "label7";
            label7.Size = new Size(61, 13);
            label7.TabIndex = 9;
            label7.Text = "Total Sales";
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
            lblpanel.Size = new Size(866, 53);
            lblpanel.TabIndex = 11;
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
            label3.Location = new Point(2758, 22);
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
            label2.Location = new Point(3102, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = " Juan Cruz";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.LightGray;
            linkLabel1.LinkColor = Color.LightGray;
            linkLabel1.Location = new Point(770, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 21);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Admin";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 28, 60);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnLogout);
            panel3.ForeColor = Color.FromArgb(28, 28, 60);
            panel3.Location = new Point(0, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 236);
            panel3.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(0, 186);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(208, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "➜]Exit ";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogout.Location = new Point(0, 150);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(208, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "➜]Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 60);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnMyorders);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 350);
            panel1.TabIndex = 9;
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
            btnProducts.Text = "📦 Inventory";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnMyorders
            // 
            btnMyorders.BackColor = Color.Transparent;
            btnMyorders.FlatStyle = FlatStyle.Flat;
            btnMyorders.Font = new Font("Segoe UI", 11F);
            btnMyorders.ForeColor = Color.FromArgb(212, 175, 55);
            btnMyorders.Location = new Point(0, 24);
            btnMyorders.Name = "btnMyorders";
            btnMyorders.Padding = new Padding(10, 0, 0, 0);
            btnMyorders.Size = new Size(208, 30);
            btnMyorders.TabIndex = 1;
            btnMyorders.Text = "📊 Dashboard";
            btnMyorders.TextAlign = ContentAlignment.MiddleLeft;
            btnMyorders.UseVisualStyleBackColor = false;
            btnMyorders.Click += btnMyorders_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.ForeColor = Color.Green;
            btnDashboard.Location = new Point(0, 72);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(208, 30);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "🚚 Orders";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(629, 261);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 484);
            Controls.Add(org);
            Controls.Add(lblpanel);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "admin_dashboard";
            Text = "admin_dashboard";
            org.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            lblpanel.ResumeLayout(false);
            lblpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel org;
        private Panel lblpanel;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panel3;
        private Button btnExit;
        private Button btnLogout;
        private Panel panel1;
        private Button btnProducts;
        private Button btnMyorders;
        private Button btnDashboard;
        private Panel panel7;
        private Label label4;
        private Panel panel6;
        private Button btnlifetime;
        private Label lblTransactions;
        private Label label9;
        private Panel panel5;
        private Button btnInQueue;
        private Label lblStock;
        private Label label6;
        private Panel panel4;
        private Button btnActive;
        private Label lblTotalSales;
        private Label label7;
        private DataGridView dataGridView1;
    }
}