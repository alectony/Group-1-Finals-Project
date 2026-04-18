namespace Bisnar_AnthonyJohn_FinalExam
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usertxt = new TextBox();
            passtxt = new TextBox();
            label4 = new Label();
            loginbtn = new Button();
            exitbtn = new Button();
            pictureBox1 = new PictureBox();
            linklabel1 = new LinkLabel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(388, 32);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY SYSTEM LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-1, -8);
            label2.Name = "label2";
            label2.Size = new Size(533, 111);
            label2.TabIndex = 1;
            label2.Text = "INVENTOY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 227);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            label3.Click += label3_Click;
            // 
            // usertxt
            // 
            usertxt.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usertxt.Location = new Point(150, 227);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(222, 29);
            usertxt.TabIndex = 3;
            // 
            // passtxt
            // 
            passtxt.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passtxt.Location = new Point(150, 264);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '•';
            passtxt.Size = new Size(222, 29);
            passtxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 269);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(153, 335);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(92, 37);
            loginbtn.TabIndex = 6;
            loginbtn.Text = "🔑 Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbtn.Location = new Point(269, 335);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(92, 37);
            exitbtn.TabIndex = 7;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linklabel1
            // 
            linklabel1.AutoSize = true;
            linklabel1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklabel1.Location = new Point(325, 296);
            linklabel1.Name = "linklabel1";
            linklabel1.Size = new Size(36, 20);
            linklabel1.TabIndex = 9;
            linklabel1.TabStop = true;
            linklabel1.Text = "here";
            linklabel1.LinkClicked += here_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(153, 296);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 10;
            label5.Text = "Dont have an account? Click";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 384);
            Controls.Add(label5);
            Controls.Add(linklabel1);
            Controls.Add(pictureBox1);
            Controls.Add(exitbtn);
            Controls.Add(loginbtn);
            Controls.Add(label4);
            Controls.Add(passtxt);
            Controls.Add(usertxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Login_Page";
            Text = "Login_Page";
            Load += Login_Page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usertxt;
        private TextBox passtxt;
        private Label label4;
        private Button loginbtn;
        private Button exitbtn;
        private PictureBox pictureBox1;
        private LinkLabel linklabel1;
        private Label label5;
    }
}