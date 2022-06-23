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

        public void SpecificRecords(List<ProductReview> review)
        {
            var recordedData = from productReviews in review
                               where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                               && productReviews.Rating > 3
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID : " + list.UserId +
                    " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

        public void CountByRecords(List<ProductReview> review)
        {
            var recordedData = review.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + " : " + list.Count);
            }
        }

        public void RetrieveProductIDAndReview(List<ProductReview> review)
        {
            var recordedData = review.Select(x => new { x.ProductId, x.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductId + " Review : " + list.Review);
            }
        }

        public void SkipRecords(List<ProductReview> productReviews)
        {
            var recordedData = (from product in productReviews
                                select product).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID : " + list.UserId +
                    " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

        public void RetrieveRecords(DataTable table)
        {
            var recordedData = from products in table.AsEnumerable() where (products.Field<string>("isLike") == true.ToString()) select products;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.Field<string>("ProductId") + " UserID : " + list.Field<string>("UserID") +
                    " Ratings : " + list.Field<string>("Ratings") + " Reviews : " + list.Field<string>("Reviews") + " isLike : " + list.Field<string>("isLike"));
            }
        }

        public void AverageRating(DataTable table)
        {
            var recordData = table.AsEnumerable().GroupBy(r => r.Field<string>("userId")).Select(r => new { userid = r.Key, averageRatings = r.Average(x => Convert.ToInt32(x.Field<string>("ratings"))) });
            foreach (var list in recordData)
            {
                Console.WriteLine("UserID : " + list.userid + " Ratings : " + list.averageRatings);
            }
        }
    }
}
