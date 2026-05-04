
﻿namespace bisnar_joel_josep_arnel
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
            pb3 = new PictureBox();
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
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
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
            panel1.Controls.Add(pb3);
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
            panel1.Location = new Point(12, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 515);
            panel1.TabIndex = 1;
            // 
            // pb3
            // 
            pb3.BackColor = Color.Transparent;
            pb3.Image = (Image)resources.GetObject("pb3.Image");
            pb3.Location = new Point(45, 194);
            pb3.Name = "pb3";
            pb3.Size = new Size(33, 43);
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.TabIndex = 12;
            pb3.TabStop = false;
            // 
            // chkpass
            // 
            chkpass.AutoSize = true;
            chkpass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkpass.Location = new Point(244, 254);
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
            pb2.Location = new Point(27, 194);
            pb2.Name = "pb2";
            pb2.Size = new Size(51, 43);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 10;
            pb2.TabStop = false;
            // 
            // pb1
            // 
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(27, 123);
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
            lblpass.ForeColor = Color.Transparent;
            lblpass.Location = new Point(84, 182);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(78, 21);
            lblpass.TabIndex = 8;
            lblpass.Text = "Password";
            // 
            // lblacc
            // 
            lblacc.AutoSize = true;
            lblacc.ForeColor = SystemColors.ControlLightLight;
            lblacc.Location = new Point(125, 437);
            lblacc.Name = "lblacc";
            lblacc.Size = new Size(132, 15);
            lblacc.TabIndex = 7;
            lblacc.Text = "Dont Have an Account?";
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
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(84, 107);
            lblname.Name = "lblname";
            lblname.Size = new Size(83, 21);
            lblname.TabIndex = 4;
            lblname.Text = "Username";
            lblname.Click += label2_Click;
            // 
            // lnkCreate
            // 
            lnkCreate.AutoSize = true;
            lnkCreate.Location = new Point(148, 467);
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
            lblget.BackColor = Color.Transparent;
            lblget.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblget.ForeColor = Color.White;
            lblget.Location = new Point(114, 18);
            lblget.Name = "lblget";
            lblget.Size = new Size(160, 36);
            lblget.TabIndex = 0;
            lblget.Text = "Get Started";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.White;
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(87, 131);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(269, 35);
            txtuser.TabIndex = 2;
            txtuser.TextChanged += txtuser_TextChanged;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.White;
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(88, 209);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(269, 35);
            txtpass.TabIndex = 1;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 100);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 62);
            label3.Name = "label3";
            label3.Size = new Size(244, 21);
            label3.TabIndex = 3;
            label3.Text = "POS * INVENTORY * EMPLOYEE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 17);
            label1.Name = "label1";
            label1.Size = new Size(192, 45);
            label1.TabIndex = 2;
            label1.Text = "GRAB n GO";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(413, 645);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "form1";
            Text = "Form1";
            Load += form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
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
        private LinkLabel lnkCreate;
        private Label lblname;
        private Button button2;
        private Label lblacc;
        private Button button3;
        private Label lblpass;
        private PictureBox pb1;
        private PictureBox pb2;
        private CheckBox chkpass;
        private Label label3;
        private Label label1;
        private PictureBox pb3;
    }
}
