using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Datos
{
    public class DInvoice
    {
        public static string connectionString = "Data Source=LAB1504-22\\SQLEXPRESS;Initial Catalog=TAREA;User ID=josue;Password=123456";

        public List<Invoice> Get()
        {
            List<Invoice> list = new List<Invoice>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "usp_ListarInvoice";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Invoice invoice = new Invoice
                                {
                                    Invoice_id = reader.GetInt32(reader.GetOrdinal("invoice_id")),
                                    Customer_id = reader.GetInt32(reader.GetOrdinal("customer_id")),
                                    Date = reader.GetDateTime(reader.GetOrdinal("date")),
                                    Total = reader.GetDecimal(reader.GetOrdinal("total")),
                                };
                                list.Add(invoice);
                            }
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }
    }
}
