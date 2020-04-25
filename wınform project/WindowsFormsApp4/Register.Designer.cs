namespace WindowsFormsApp4
{
    partial class Register
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
            this.rgsemail = new System.Windows.Forms.Label();
            this.txtRgsEmail = new System.Windows.Forms.TextBox();
            this.rgsname = new System.Windows.Forms.Label();
            this.txtRgsname = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtRgsPassword = new System.Windows.Forms.TextBox();
            this.rgspassword = new System.Windows.Forms.Label();
            this.repeatrgspassword = new System.Windows.Forms.Label();
            this.txtRgsRepeatePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rgsemail
            // 
            this.rgsemail.AutoSize = true;
            this.rgsemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgsemail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rgsemail.Location = new System.Drawing.Point(12, 19);
            this.rgsemail.Name = "rgsemail";
            this.rgsemail.Size = new System.Drawing.Size(52, 20);
            this.rgsemail.TabIndex = 1;
            this.rgsemail.Text = "Emaıl:";
            // 
            // txtRgsEmail
            // 
            this.txtRgsEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRgsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRgsEmail.Location = new System.Drawing.Point(16, 52);
            this.txtRgsEmail.Name = "txtRgsEmail";
            this.txtRgsEmail.Size = new System.Drawing.Size(193, 26);
            this.txtRgsEmail.TabIndex = 2;
            // 
            // rgsname
            // 
            this.rgsname.AutoSize = true;
            this.rgsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgsname.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rgsname.Location = new System.Drawing.Point(12, 84);
            this.rgsname.Name = "rgsname";
            this.rgsname.Size = new System.Drawing.Size(84, 20);
            this.rgsname.TabIndex = 5;
            this.rgsname.Text = "Full Name:";
            // 
            // txtRgsname
            // 
            this.txtRgsname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRgsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRgsname.Location = new System.Drawing.Point(16, 120);
            this.txtRgsname.Name = "txtRgsname";
            this.txtRgsname.Size = new System.Drawing.Size(193, 26);
            this.txtRgsname.TabIndex = 4;
            // 
            // btnregister
            // 
            this.btnregister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnregister.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnregister.Location = new System.Drawing.Point(16, 324);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(193, 32);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtRgsPassword
            // 
            this.txtRgsPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRgsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRgsPassword.Location = new System.Drawing.Point(16, 190);
            this.txtRgsPassword.Name = "txtRgsPassword";
            this.txtRgsPassword.Size = new System.Drawing.Size(193, 26);
            this.txtRgsPassword.TabIndex = 7;
            this.txtRgsPassword.UseSystemPasswordChar = true;
           
            // 
            // rgspassword
            // 
            this.rgspassword.AutoSize = true;
            this.rgspassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgspassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rgspassword.Location = new System.Drawing.Point(12, 167);
            this.rgspassword.Name = "rgspassword";
            this.rgspassword.Size = new System.Drawing.Size(82, 20);
            this.rgspassword.TabIndex = 8;
            this.rgspassword.Text = "Password:";
            // 
            // repeatrgspassword
            // 
            this.repeatrgspassword.AutoSize = true;
            this.repeatrgspassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.repeatrgspassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.repeatrgspassword.Location = new System.Drawing.Point(12, 238);
            this.repeatrgspassword.Name = "repeatrgspassword";
            this.repeatrgspassword.Size = new System.Drawing.Size(139, 20);
            this.repeatrgspassword.TabIndex = 9;
            this.repeatrgspassword.Text = "Repeat Password:";
            // 
            // txtRgsRepeatePassword
            // 
            this.txtRgsRepeatePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRgsRepeatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRgsRepeatePassword.Location = new System.Drawing.Point(16, 261);
            this.txtRgsRepeatePassword.Name = "txtRgsRepeatePassword";
            this.txtRgsRepeatePassword.Size = new System.Drawing.Size(193, 26);
            this.txtRgsRepeatePassword.TabIndex = 10;
            this.txtRgsRepeatePassword.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(255, 409);
            this.Controls.Add(this.txtRgsRepeatePassword);
            this.Controls.Add(this.repeatrgspassword);
            this.Controls.Add(this.rgspassword);
            this.Controls.Add(this.txtRgsPassword);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.rgsname);
            this.Controls.Add(this.txtRgsname);
            this.Controls.Add(this.txtRgsEmail);
            this.Controls.Add(this.rgsemail);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rgsemail;
        private System.Windows.Forms.TextBox txtRgsEmail;
        private System.Windows.Forms.Label rgsname;
        private System.Windows.Forms.TextBox txtRgsname;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox txtRgsPassword;
        private System.Windows.Forms.Label rgspassword;
        private System.Windows.Forms.Label repeatrgspassword;
        private System.Windows.Forms.TextBox txtRgsRepeatePassword;
    }
}