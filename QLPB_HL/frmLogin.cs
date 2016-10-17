using System;
using System.Windows.Forms;
using Model.ViewModel;
using Service.Interfaces;

namespace QLPB_HL
{
    public partial class frmLogin : Form
    {
        private IUserService userService;
        public frmLogin(IUserService userService)
        {
            this.userService = userService;
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            this.btnOk.Enabled = false;
            var result = await userService.Login(new LoginViewModel()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            });
            this.btnOk.Enabled = true;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
