using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

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
            Cursor.Current = Cursors.WaitCursor;
            this.btnOk.Enabled = false;
            this.error_message_lb.Text = string.Empty;
            var result = await userService.Login(new LoginViewModel()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text.ToMD5()
            });
            this.btnOk.Enabled = true;
            btnOk.Image = null;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.error_message_lb.Text = Resources.Message.UserIsValided;
                this.error_message_lb.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        { 
            this.cbxPeriod.DataSource = await userService.GetUserWorkingDay();
        }
    }
}
