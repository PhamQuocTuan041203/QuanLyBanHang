using DAL;
using DTO;
using System.Data;
using System.Text.RegularExpressions;

namespace BUS
{
    public class BUS_Customer
    {
        DAL_Customer dalCustomer = new DAL_Customer();

        public DataTable ListOfCustomers()
        {
            return dalCustomer.ListOfCustomers();
        }

        public bool InsertKhachHang(DTO_Customer customer)
        {
            return dalCustomer.InsertCustomer(customer);
        }

        public bool UpdateCustomer(DTO_Customer customer)
        {
            return dalCustomer.UpdateCustomer(customer);
        }

        public DataTable SearchCustomer(string name)
        {
            return dalCustomer.SearchCustomer(name);
        }

        public string[] ListCustomerIdName()
        {
            return dalCustomer.ListCustomerIdName();
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^0\d{9}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
