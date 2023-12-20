using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        BUS_Employee busEmployee = new BUS_Employee();
        frmEmployee fEmployee = new frmEmployee();
        frmProduct fProduct = new frmProduct();
        frmCustomer fCustomer = new frmCustomer();
        frmStatistic fStatistic = new frmStatistic();
        frmAccount fAccount;
        frmBill fBill;

        public frmMain(string email)
        {
            InitializeComponent();

            if (!busEmployee.GetEmployeeRole(email))
            {
                btnEmployee.Visible = false;
                btnStatistic.Visible = false;
                btnProduct.Visible = false;
                btnCustomer.Checked = true;

                fCustomer.TopLevel = false;
                fCustomer.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(fCustomer);
                fCustomer.Show();
            }
            else
            {
                btnStatistic.Checked = true;
                fStatistic.TopLevel = false;
                fStatistic.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(fStatistic);
                fStatistic.Show();
            }

            fAccount = new frmAccount(email);
            fBill = new frmBill(email);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            fEmployee.TopLevel = false;
            fEmployee.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(fEmployee);
            fEmployee.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fProduct.TopLevel = false;
            fProduct.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(fProduct);
            fProduct.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fCustomer.TopLevel = false;
            fCustomer.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(fCustomer);
            fCustomer.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            fBill.TopLevel = false;
            fBill.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(fBill);
            fBill.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount.TopLevel = false;
            fAccount.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(fAccount);
            fAccount.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            fStatistic.TopLevel = false;
            fStatistic.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(fStatistic);
            fStatistic.Show();
        }
    }
}
