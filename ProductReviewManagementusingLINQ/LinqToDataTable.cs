using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementusingLINQ
{
    public class LinqToDataTable
    {
        public void AddToDatatable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "Chai");
            table.Rows.Add("2", "Queso Cabrales");
            table.Rows.Add("3", "Tofu");
            table.Rows.Add("4", "Buiscuit");
            table.Rows.Add("5", "Paneer");
            table.Rows.Add("6", "Omlet");
            table.Rows.Add("7", "Chicken");
            table.Rows.Add("8", "Mutton");
            table.Rows.Add("9", "Keema");
            table.Rows.Add("10", "Roll");
            table.Rows.Add("11", "Samosa");
            table.Rows.Add("12", "Kachori");
            table.Rows.Add("13", "Idli");
            table.Rows.Add("14", "Dosa");
            table.Rows.Add("15", "Biryani");
            table.Rows.Add("16", "Chass");
            table.Rows.Add("17", "Wada Pav");
            table.Rows.Add("18", "Dabeli");
            table.Rows.Add("19", "Naan");
            table.Rows.Add("20", "Laccha Paratha");
            table.Rows.Add("21", "Daal");
            table.Rows.Add("22", "Sabzi");
            table.Rows.Add("23", "Kabaab");
            table.Rows.Add("24", "Pav Bhaji");
            table.Rows.Add("25", "Ice Cream");

            DisplayProducts(table);
        }

        public void DisplayProducts(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("Product Names : \n");
            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
