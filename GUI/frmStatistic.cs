using BUS;
using Guna.Charts.WinForms;
using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class frmStatistic : Form
    {
        BUS_Bill busBill = new BUS_Bill();

        public frmStatistic()
        {
            InitializeComponent();
        }

        private void chtImportProduct_Load(object sender, EventArgs e)
        {
            Bar(chtImportProduct);
        }

        public void Bar(GunaChart chart)
        {
            chart.YAxes.GridLines.Display = false;
            chart.Title.Text = "Tổng doanh thu tháng";
            var dataset = new GunaBarDataset
            {
                Label = "Doanh thu"
            };

            dataset.DataPoints.Add("Tháng 1", busBill.GetRevenueInJanuary());
            dataset.DataPoints.Add("Tháng 2", busBill.GetRevenueInFebruary());
            dataset.DataPoints.Add("Tháng 3", busBill.GetRevenueInMarch());
            dataset.DataPoints.Add("Tháng 4", busBill.GetRevenueInApril());
            dataset.DataPoints.Add("Tháng 5", busBill.GetRevenueInMay());
            dataset.DataPoints.Add("Tháng 6", busBill.GetRevenueInJune());
            dataset.DataPoints.Add("Tháng 7", busBill.GetRevenueInJuly());
            dataset.DataPoints.Add("Tháng 8", busBill.GetRevenueInAugust());
            dataset.DataPoints.Add("Tháng 9", busBill.GetRevenueInSeptember());
            dataset.DataPoints.Add("Tháng 10", busBill.GetRevenueInOctober());
            dataset.DataPoints.Add("Tháng 11", busBill.GetRevenueInNovember());
            dataset.DataPoints.Add("Tháng 12", busBill.GetRevenueInDecember());

            chart.Datasets.Add(dataset);
            chart.Update();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chtImportProduct.Datasets.Clear();
            Bar(chtImportProduct);
        }
    }
}
