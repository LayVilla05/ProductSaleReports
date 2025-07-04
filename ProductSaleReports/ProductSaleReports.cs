using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace ProductSaleReports
{
    public partial class ProductSaleReports : DevExpress.XtraReports.UI.XtraReport
    {
        public ProductSaleReports()
        {
            InitializeComponent();
        }

        public static List<SaleDto> GetSales(DateTime startDate, DateTime endDate)
        {
            var list = new List<SaleDto>();
            string connStr = "Server=LAYVILLA\\LAYVILLA;Database=ProductSalesDB;Integrated Security=True;";

            try
            {
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("P_GetProductSales", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new SaleDto
                            {
                                ProductCode = reader["PRODUCTCODE"].ToString(),
                                ProductName = reader["PRODUCTNAME"].ToString(),
                                Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                UnitPrice = Convert.ToDecimal(reader["UNITPRICE"]),
                                SaleDate = Convert.ToDateTime(reader["SALEDATE"])

                            });
                        }
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching sales data: " + ex.Message);
                return list;

            }
        }

    }
}
