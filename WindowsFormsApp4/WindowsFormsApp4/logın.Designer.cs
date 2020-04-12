namespace WindowsFormsApp4
{
    partial class logın
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
            this.labelloginemail = new System.Windows.Forms.Label();
            this.txtlogınEmaıl = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtloginpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelloginemail
            // 
            this.labelloginemail.AutoSize = true;
            this.labelloginemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelloginemail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelloginemail.Location = new System.Drawing.Point(30, 27);
            this.labelloginemail.Name = "labelloginemail";
            this.labelloginemail.Size = new System.Drawing.Size(52, 20);
            this.labelloginemail.TabIndex = 0;
            this.labelloginemail.Text = "Emaıl:";
            this.labelloginemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlogınEmaıl
            // 
            this.txtlogınEmaıl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlogınEmaıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtlogınEmaıl.Location = new System.Drawing.Point(34, 60);
            this.txtlogınEmaıl.Name = "txtlogınEmaıl";
            this.txtlogınEmaıl.Size = new System.Drawing.Size(159, 26);
            this.txtlogınEmaıl.TabIndex = 1;
            this.txtlogınEmaıl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(34, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // txtloginpassword
            // 
            this.txtloginpassword.AutoSize = true;
            this.txtloginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtloginpassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtloginpassword.Location = new System.Drawing.Point(30, 99);
            this.txtloginpassword.Name = "txtloginpassword";
            this.txtloginpassword.Size = new System.Drawing.Size(82, 20);
            this.txtloginpassword.TabIndex = 3;
            this.txtloginpassword.Text = "Password:";
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnlogin.Location = new System.Drawing.Point(34, 192);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(159, 32);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = " Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // btnregister
            // 
            this.btnregister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnregister.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnregister.Location = new System.Drawing.Point(34, 253);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(159, 32);
            this.btnregister.TabIndex = 5;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // logın
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(288, 351);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtloginpassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtlogınEmaıl);
            this.Controls.Add(this.labelloginemail);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "logın";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logın";
            this.Load += new System.EventHandler(this.logın_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelloginemail;
        private System.Windows.Forms.TextBox txtlogınEmaıl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtloginpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
    }
}