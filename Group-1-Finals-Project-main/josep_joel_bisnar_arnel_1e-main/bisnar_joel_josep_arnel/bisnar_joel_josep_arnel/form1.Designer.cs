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
            chkpass = new CheckBox();
            pb2 = new PictureBox();
            pb1 = new PictureBox();
            lblpass = new Label();
            lblacc = new Label();
            button3 = new Button();
            lblname = new Label();
            lnkCreate = new LinkLabel();
            lblget = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            panel2 = new Panel();
            lblstore = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(55, 322);
            button1.Name = "button1";
            button1.Size = new Size(287, 33);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(chkpass);
            panel1.Controls.Add(pb2);
            panel1.Controls.Add(pb1);
            panel1.Controls.Add(lblpass);
            panel1.Controls.Add(lblacc);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblname);
            panel1.Controls.Add(lnkCreate);
            panel1.Controls.Add(lblget);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(314, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 547);
            panel1.TabIndex = 1;
            // 
            // chkpass
            // 
            chkpass.AutoSize = true;
            chkpass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkpass.Location = new Point(242, 264);
            chkpass.Name = "chkpass";
            chkpass.Size = new Size(112, 19);
            chkpass.TabIndex = 11;
            chkpass.Text = "Show  Password";
            chkpass.UseVisualStyleBackColor = true;
            chkpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pb2
            // 
            pb2.BackColor = Color.Transparent;
            pb2.Image = (Image)resources.GetObject("pb2.Image");
            pb2.Location = new Point(9, 197);
            pb2.Name = "pb2";
            pb2.Size = new Size(61, 51);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 10;
            pb2.TabStop = false;
            // 
            // pb1
            // 
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(19, 125);
            pb1.Name = "pb1";
            pb1.Size = new Size(51, 43);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 9;
            pb1.TabStop = false;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpass.ForeColor = Color.Black;
            lblpass.Location = new Point(85, 196);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(78, 21);
            lblpass.TabIndex = 8;
            lblpass.Text = "Password";
            // 
            // lblacc
            // 
            lblacc.AutoSize = true;
            lblacc.ForeColor = SystemColors.ControlLightLight;
            lblacc.Location = new Point(125, 452);
            lblacc.Name = "lblacc";
            lblacc.Size = new Size(132, 15);
            lblacc.TabIndex = 7;
            lblacc.Text = "Dont Have an Account?";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(55, 383);
            button3.Name = "button3";
            button3.Size = new Size(287, 35);
            button3.TabIndex = 6;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.Black;
            lblname.Location = new Point(85, 114);
            lblname.Name = "lblname";
            lblname.Size = new Size(83, 21);
            lblname.TabIndex = 4;
            lblname.Text = "Username";
            lblname.Click += label2_Click;
            // 
            // lnkCreate
            // 
            lnkCreate.AutoSize = true;
            lnkCreate.Location = new Point(147, 488);
            lnkCreate.Name = "lnkCreate";
            lnkCreate.Size = new Size(89, 15);
            lnkCreate.TabIndex = 3;
            lnkCreate.TabStop = true;
            lnkCreate.Text = "Create Account";
            lnkCreate.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // lblget
            // 
            lblget.AutoSize = true;
            lblget.BackColor = SystemColors.ButtonHighlight;
            lblget.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblget.ForeColor = Color.DodgerBlue;
            lblget.Location = new Point(35, 33);
            lblget.Name = "lblget";
            lblget.Size = new Size(160, 36);
            lblget.TabIndex = 0;
            lblget.Text = "Get Started";
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.ScrollBar;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(85, 138);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(269, 28);
            txtuser.TabIndex = 2;
            txtuser.TextChanged += txtuser_TextChanged;
            // 
            // txtpass
            // 
            txtpass.BackColor = SystemColors.ScrollBar;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(85, 220);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(269, 28);
            txtpass.TabIndex = 1;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Magenta;
            panel2.Controls.Add(lblstore);
            panel2.Location = new Point(314, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 57);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // lblstore
            // 
            lblstore.AutoSize = true;
            lblstore.BackColor = Color.Magenta;
            lblstore.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstore.ForeColor = SystemColors.ButtonHighlight;
            lblstore.Location = new Point(35, 11);
            lblstore.Name = "lblstore";
            lblstore.Size = new Size(156, 36);
            lblstore.TabIndex = 1;
            lblstore.Text = "name store";
            lblstore.Click += label1_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1019, 645);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "form1";
            Text = "Form1";
            Load += form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
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
        private Label lblget;
        private Label lblstore;
        private LinkLabel lnkCreate;
        private Label lblname;
        private Button button2;
        private Label lblacc;
        private Button button3;
        private Label lblpass;
        private PictureBox pb1;
        private PictureBox pb2;
        private CheckBox chkpass;
    }
}
