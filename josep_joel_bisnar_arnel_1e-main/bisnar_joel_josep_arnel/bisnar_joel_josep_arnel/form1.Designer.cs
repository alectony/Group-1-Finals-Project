namespace bisnar_joel_josep_arnel
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            button1 = new Button();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            Login = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 326);
            button1.Name = "button1";
            button1.Size = new Size(287, 33);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(21, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 547);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(246, 258);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show  Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(89, 190);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 452);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 7;
            label4.Text = "Dont Have an Account?";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(55, 379);
            button3.Name = "button3";
            button3.Size = new Size(287, 35);
            button3.TabIndex = 6;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 4;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(147, 488);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = Color.Transparent;
            Login.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(30, 20);
            Login.Name = "Login";
            Login.Size = new Size(160, 36);
            Login.TabIndex = 0;
            Login.Text = "Get Started";
            Login.Click += Login_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.White;
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(89, 132);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(269, 35);
            txtuser.TabIndex = 2;
            txtuser.TextChanged += txtuser_TextChanged;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.White;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(89, 214);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(269, 28);
            txtpass.TabIndex = 1;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(21, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 100);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 57);
            label3.Name = "label3";
            label3.Size = new Size(244, 21);
            label3.TabIndex = 1;
            label3.Text = "POS * INVENTORY * EMPLOYEE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 12);
            label1.Name = "label1";
            label1.Size = new Size(192, 45);
            label1.TabIndex = 0;
            label1.Text = "GRAB n GO";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 680);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "form1";
            Text = "Form1";
            Load += form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox txtuser;
        private TextBox txtpass;
        private Panel panel2;
        private Label Login;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button button2;
        private Label label4;
        private Button button3;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private Label label1;
        private Label label3;
    }
}
