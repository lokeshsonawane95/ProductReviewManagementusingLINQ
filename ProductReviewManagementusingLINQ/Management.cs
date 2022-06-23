using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementusingLINQ
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> review)
        {

            var recordedData = (from productReviews in review orderby productReviews.Rating descending select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID : " + list.UserId + 
                    " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);

            }
        }
    }
}
