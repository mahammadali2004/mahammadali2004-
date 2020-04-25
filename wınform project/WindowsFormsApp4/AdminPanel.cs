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
    public partial class AdminPanel : Form
    {
        private readonly Form _login;

        private readonly P507ProjectEntities _db;
        private enum Grant { Activate=0,Admin=1,Delete=2}
        public AdminPanel(Form login)
        {
            InitializeComponent();
            _login = login;
            _db = new P507ProjectEntities();
        }


        private void AdminPanel_FromClosing(object sender,FormClosingEventArgs e)
        {

            _login.Close();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
            RefreshDgv();
            cmbCase.DataSource = Enum.GetValues(typeof(Grant));
        }
        private void RefreshDgv()
        {
            lbNewuserCount.Text = _db.Users.Count(u => u.IsActivated == false && IsDeleted == false).ToString(); 
            dgvUsers.DataSource = _db.Users.Where(u => u.IsActivated == false && IsDeleted == false).Select(u => new
            {
                u.Id,
                u.Fullname,
                u.Email,
                u.IsActivated

            }).Tolist();
        }
        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      txtUserEmail.Text=dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            User user = _db.Users.First(u => u.Email == txtUserEmail.Text.Trim());
            int SelectCase = cmbCase.SelectedIndex;
            switch (SelectCase) {

                case (int)Grant.Activate:
                    user.IsActivated = true;
                    break;
                case (int)Grant.Admin:
                    user.IsAdmin = true;
                    user.IsActivated = true;
                    break;
                case (int)Grant.Delete:
                   user.IsDeleted = true;

                    break;
                default:
                    break;
            
            
            }
            await _db.SaveChangeAsync();

            RefreshDgv();
            txtUserEmail.Text = "";
        }
    }
}
