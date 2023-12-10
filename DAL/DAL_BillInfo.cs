using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_BillInfo : DbConnect
    {
        public DataTable ListBillInfo()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListBillInfo";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool InsertBillInfo(DTO_BillInfo billInfo, int quantity)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertBillInfo";
                cmd.Parameters.AddWithValue("productId", billInfo.ProductId);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("unitPrice", billInfo.UnitPrice);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public double GetTotalPrice()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetTotalPrice";
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
