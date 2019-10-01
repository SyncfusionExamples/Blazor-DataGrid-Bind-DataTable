using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample
{
    public class OrdersDetails
    {
        public OrdersDetails()
        {

        }
        public static DataTable GetAllRecords()
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("OrderID", typeof(long)),
        new DataColumn("CustomerID", typeof(string)),
        new DataColumn("EmployeeID",typeof(int)),
        new DataColumn("OrderDate",typeof(DateTime))
    });
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                dt.Rows.Add(code + 1, "ALF", i + 0, new DateTime(1991, 05, 15));
                dt.Rows.Add(code + 2, "ANA", i + 2, new DateTime(1990, 04, 04));
                dt.Rows.Add(code + 3, "ANT", i + 1, new DateTime(1957, 11, 30));
                dt.Rows.Add(code + 4, "BLO", i + 3, new DateTime(1930, 10, 22));
                dt.Rows.Add(code + 5, "BOL", i + 4, new DateTime(1953, 02, 18));
                code += 5;
            }
            return dt;
        }
    }
}
