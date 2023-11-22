using BUS;
using Guna.Charts.WinForms;
using System;
using System.Windows.Forms;

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
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;
            chart.Title.Text = "Tổng doanh thu tháng";

            //Create a new dataset 
            var dataset = new GunaBarDataset
            {
                Label = "Doanh thu"
            };
            dataset.DataPoints.Add("Tháng 6", busBill.GetRevenueInMay());
            dataset.DataPoints.Add("Tháng 7", busBill.GetRevenueInJune());
            dataset.DataPoints.Add("Tháng 8", busBill.GetRevenueInJuly());
            dataset.DataPoints.Add("Tháng 11", busBill.GetRevenueInNovember());

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chtImportProduct.Datasets.Clear();
            Bar(chtImportProduct);
        }
    }
}
