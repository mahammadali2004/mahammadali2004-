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
    public partial class Register : Form
    {
        private readonly Form _login;

        private readonly P507ProjectEntities _db;
        public Register(Form login)

        {
            InitializeComponent();
            _login = login;
            _db = new P507ProjectEntities();

        }

        private async void btnregister_Click(object sender, EventArgs e)
        {
             
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Show();
        }

        private async Task textBox2_TextChangedAsync(object sender, EventArgs e)
        {
            string email = txtRgsEmail.Text.Trim();
            string fullname = txtRgsname.Text.Trim();
            string password = txtRgsPassword.Text.Trim();
            string checkpassword = txtRgsRepeatePassword.Text.Trim();
            if (IsValid(email, fullname, password, checkpassword)) {
                return;


            }
            bool emailInDb = _db.Users.Any(u => u.Email == email);
            if (emailInDb)
            {
                 
                MessageBox.Show("this email already exits!!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }



            User user = new User
            {
                Email = email,
                Fullname = fullname,
                Password = password.HashPassword,

            };

            _db.Users.Add(user);
            await _db.SaveChangeAsync();
            MessageBox.Show("Successfully regiter. Please wait confirmation!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private bool IsValid(string email, string fullname, string password, string checkpassword) {
            if (email == "" || fullname == "" || password == "" || checkpassword == "")
            { MessageBox.Show("Fill all input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!email.IsEmail()) {

                MessageBox.Show("Please enter valid email !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            if (password != checkpassword) {
                MessageBox.Show("Please repeate password corrently!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

             
            return true;
                }
    }
}
