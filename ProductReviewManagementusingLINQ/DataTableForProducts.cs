using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementusingLINQ
{
    public class DataTableForProducts
    {
        DataTable table = new DataTable();

        public void AddDataTable()
        {
            table.Columns.Add("ProductId");
            table.Columns.Add("UserID");
            table.Columns.Add("Ratings");
            table.Columns.Add("Reviews");
            table.Columns.Add("isLike");
            table.Rows.Add("1", "1", "5", "Good", true);
            table.Rows.Add("2", "3", "4", "Good", true);
            table.Rows.Add("3", "4", "4", "Good", true);
            table.Rows.Add("4", "5", "5", "Good", true);
            table.Rows.Add("5", "4", "3", "Average", true);
            table.Rows.Add("6", "5", "1", "Bad", false);
            table.Rows.Add("7", "10", "5", "Good", true);
            table.Rows.Add("8", "10", "5", "Good", true);
            table.Rows.Add("9", "3", "4", "Good", true);
            table.Rows.Add("10", "2", "2", "Bad", false);
            table.Rows.Add("11", "3", "3", "Average", true);
            table.Rows.Add("12", "1", "3", "Average", false);
            table.Rows.Add("13", "10", "5", "Good", true);
            table.Rows.Add("14", "10", "6", "Good", true);
            table.Rows.Add("15", "10", "6", "Good", true);
            table.Rows.Add("16", "10", "5", "Average", true);
            table.Rows.Add("17", "10", "3", "Bad", true);
            table.Rows.Add("18", "10", "1", "Bad", true);
            table.Rows.Add("19", "10", "7", "Good", true);
            table.Rows.Add("20", "10", "2", "Bad", true);
            table.Rows.Add("21", "10", "9", "Good", true);

            Management productManagement = new Management();
            //productManagement.RetrieveRecords(table);

            //productManagement.AverageRating(table);

            //productManagement.RetrieveSpecificMessage(table);

            productManagement.RetrieveSpecificID(table);
        }
    }
}
