using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class logın : Form
    {


        private readonly P507ProjectEntities _db;
        public logın()
        {
            InitializeComponent();
            _db = new P507ProjectEntities(); 
        }

        private void logın_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtlogınEmaıl.Text.Trim();
            string password = txtloginpassword.Text.Trim();
            if (email == "" && password == "")
            {
                MessageBox.Show("Fill all input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User user = _db.Users.FirstOrDefault(u => u.Email == email);
            private bool IsValid(User user)
            {
                if (user == null)
                {

                    MessageBox.Show("Not find user releted this email  !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (user.IsDeleted)
                {
                    MessageBox.Show("Your" MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;

            }
        }
    }
}
