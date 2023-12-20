using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        BUS_Employee busEmployee = new BUS_Employee();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                if (busEmployee.Login(txtEmail.Text, txtPassword.Text))
                {
                    frmMain fMain = new frmMain(txtEmail.Text);
                    this.Hide();
                    fMain.ShowDialog();
                    this.Show();
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                txtEmail.Focus();
                busEmployee = new BUS_Employee();
                if (busEmployee.IsExistEmail(txtEmail.Text))
                {
                    DialogResult result = MessageBox.Show("Hệ thống sẽ gửi mật khẩu mới đến Gmail của bạn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string password = busEmployee.GetRandomPassword();
                        if (busEmployee.UpdatePassword(txtEmail.Text, password))
                        {
                            SendMail loader = new SendMail(txtEmail.Text, password, true);
                            loader.ShowDialog();

                            MessageBox.Show("Mật khẩu đã được tạo mới.\n"
                                + loader.Result, "Thông báo");
                        }
                        else
                            MessageBox.Show("Không thực hiện được", "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Email không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
