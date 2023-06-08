namespace Quizmaster
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labusernamelogin = new System.Windows.Forms.Label();
            this.labpassword = new System.Windows.Forms.Label();
            this.txtpasswordlogin = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusernamelogin = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnnewaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labusernamelogin
            // 
            this.labusernamelogin.AutoSize = true;
            this.labusernamelogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labusernamelogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labusernamelogin.Location = new System.Drawing.Point(159, 291);
            this.labusernamelogin.Name = "labusernamelogin";
            this.labusernamelogin.Size = new System.Drawing.Size(98, 21);
            this.labusernamelogin.TabIndex = 13;
            this.labusernamelogin.Text = "Username:";
            // 
            // labpassword
            // 
            this.labpassword.AutoSize = true;
            this.labpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labpassword.Location = new System.Drawing.Point(159, 379);
            this.labpassword.Name = "labpassword";
            this.labpassword.Size = new System.Drawing.Size(93, 21);
            this.labpassword.TabIndex = 14;
            this.labpassword.Text = "Password:";
            // 
            // txtpasswordlogin
            // 
            this.txtpasswordlogin.BackColor = System.Drawing.Color.White;
            this.txtpasswordlogin.ForeColor = System.Drawing.Color.Black;
            this.txtpasswordlogin.Location = new System.Drawing.Point(159, 407);
            this.txtpasswordlogin.Name = "txtpasswordlogin";
            this.txtpasswordlogin.PasswordChar = '*';
            this.txtpasswordlogin.Size = new System.Drawing.Size(285, 27);
            this.txtpasswordlogin.TabIndex = 5;
            this.txtpasswordlogin.TextChanged += new System.EventHandler(this.txtpasswordlogin_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.Location = new System.Drawing.Point(240, 440);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(99, 41);
            this.btnlogin.TabIndex = 17;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Transparent;
            this.btnadmin.FlatAppearance.BorderSize = 0;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadmin.ForeColor = System.Drawing.Color.Black;
            this.btnadmin.Location = new System.Drawing.Point(216, 487);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(162, 40);
            this.btnadmin.TabIndex = 19;
            this.btnadmin.Text = "Admin login";
            this.btnadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtusernamelogin
            // 
            this.txtusernamelogin.BackColor = System.Drawing.Color.White;
            this.txtusernamelogin.ForeColor = System.Drawing.Color.Black;
            this.txtusernamelogin.Location = new System.Drawing.Point(159, 325);
            this.txtusernamelogin.Name = "txtusernamelogin";
            this.txtusernamelogin.Size = new System.Drawing.Size(285, 27);
            this.txtusernamelogin.TabIndex = 5;
            this.txtusernamelogin.TextChanged += new System.EventHandler(this.txtusernamelogin_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnnewaccount
            // 
            this.btnnewaccount.BackColor = System.Drawing.Color.Transparent;
            this.btnnewaccount.FlatAppearance.BorderSize = 0;
            this.btnnewaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewaccount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnewaccount.ForeColor = System.Drawing.Color.Black;
            this.btnnewaccount.Image = ((System.Drawing.Image)(resources.GetObject("btnnewaccount.Image")));
            this.btnnewaccount.Location = new System.Drawing.Point(159, 573);
            this.btnnewaccount.Name = "btnnewaccount";
            this.btnnewaccount.Size = new System.Drawing.Size(285, 55);
            this.btnnewaccount.TabIndex = 18;
            this.btnnewaccount.Text = "Create a new account";
            this.btnnewaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnewaccount.UseVisualStyleBackColor = false;
            this.btnnewaccount.Click += new System.EventHandler(this.btnnewaccount_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(617, 651);
            this.Controls.Add(this.btnnewaccount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.txtpasswordlogin);
            this.Controls.Add(this.txtusernamelogin);
            this.Controls.Add(this.labpassword);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labusernamelogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labusernamelogin;
        private System.Windows.Forms.Label labpassword;
        private System.Windows.Forms.TextBox txtpasswordlogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.TextBox txtusernamelogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnnewaccount;
    }
}