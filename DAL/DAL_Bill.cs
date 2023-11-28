using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Bill : DbConnect
    {
        public DataTable ListOfBills()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListOfBills";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool InsertBill(DTO_Bill bill)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertBill";
                cmd.Parameters.AddWithValue("employeeId", bill.EmployeeId);
                cmd.Parameters.AddWithValue("customerId", bill.CustomerId);
                cmd.Parameters.AddWithValue("totalPrice", bill.TotalPrice);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable SearchCustomerInBill(string name)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchCustomerInBill";
                cmd.Parameters.AddWithValue("name", name);
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInJanuary()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInJanuary";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInFebruary()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInFebruary";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInMarch()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInMarch";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInApril()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInApril";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInMay()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInMay";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInJune()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInJune";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInJuly()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInJuly";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInAugust()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInAugust";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInSeptember()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInSeptember";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInOctober()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInOctober";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInNovember()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInNovember";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetRevenueInDecember()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRevenueInDecember";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
