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
        public Register(Form login)
        {
            InitializeComponent();
            _login = login;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
             
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Show();
        }
    }
}
