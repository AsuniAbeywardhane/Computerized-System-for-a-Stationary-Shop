﻿namespace WindowsFormsApplication32
{
    partial class LOGIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblun = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblun
            // 
            resources.ApplyResources(this.lblun, "lblun");
            this.lblun.BackColor = System.Drawing.Color.Transparent;
            this.lblun.Name = "lblun";
            // 
            // lblpwd
            // 
            resources.ApplyResources(this.lblpwd, "lblpwd");
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Name = "lblpwd";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkCyan;
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkCyan;
            resources.ApplyResources(this.btnexit, "btnexit");
            this.btnexit.Name = "btnexit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtun
            // 
            resources.ApplyResources(this.txtun, "txtun");
            this.txtun.Name = "txtun";
            // 
            // txtpwd
            // 
            resources.ApplyResources(this.txtpwd, "txtpwd");
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.TextChanged += new System.EventHandler(this.txtpwd_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txttime
            // 
            resources.ApplyResources(this.txttime, "txttime");
            this.txttime.Name = "txttime";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // LOGIN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}