using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Bill
    {
        DAL_Bill dalBill = new DAL_Bill();

        public DataTable ListOfBills()
        {
            return dalBill.ListOfBills();
        }

        public bool InsertBill(DTO_Bill bill)
        {
            return dalBill.InsertBill(bill);
        }

        public DataTable SearchCustomerInBill(string name)
        {
            return dalBill.SearchCustomerInBill(name);
        }

        public double GetRevenueInJanuary()
        {
            return dalBill.GetRevenueInJanuary();
        }

        public double GetRevenueInFebruary()
        {
            return dalBill.GetRevenueInFebruary();
        }

        public double GetRevenueInMarch()
        {
            return dalBill.GetRevenueInMarch();
        }

        public double GetRevenueInApril()
        {
            return dalBill.GetRevenueInApril();
        }

        public double GetRevenueInMay()
        {
            return dalBill.GetRevenueInMay();
        }

        public double GetRevenueInJune()
        {
            return dalBill.GetRevenueInJune();
        }

        public double GetRevenueInJuly()
        {
            return dalBill.GetRevenueInJuly();
        }

        public double GetRevenueInAugust()
        {
            return dalBill.GetRevenueInAugust();
        }

        public double GetRevenueInSeptember()
        {
            return dalBill.GetRevenueInSeptember();
        }

        public double GetRevenueInOctober()
        {
            return dalBill.GetRevenueInOctober();
        }

        public double GetRevenueInNovember()
        {
            return dalBill.GetRevenueInNovember();
        }

        public double GetRevenueInDecember()
        {
            return dalBill.GetRevenueInDecember();
        }
    }
}
