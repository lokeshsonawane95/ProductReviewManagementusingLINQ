namespace ProductReviewManagementusingLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Product Review Management\n\n");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=2,UserId=2,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=3,UserId=3,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=4,UserId=4,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=5,UserId=02,Rating=3,Review="Average",isLike=false},
                new ProductReview(){ProductId=6,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=7,UserId=14,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=8,UserId=13,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=9,UserId=9,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=10,UserId=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=11,UserId=05,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=12,UserId=08,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=13,UserId=06,Rating=3,Review="Average",isLike=true},
                new ProductReview(){ProductId=14,UserId=08,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=15,UserId=02,Rating=3,Review="Average",isLike=false},
                new ProductReview(){ProductId=16,UserId=01,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=17,UserId=07,Rating=2,Review="Bad",isLike=false },
                new ProductReview(){ProductId=18,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=19,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=20,UserId=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=21,UserId=10,Rating=3,Review="Average",isLike=true},
                new ProductReview(){ProductId=22,UserId=13,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=23,UserId=15,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=24,UserId=12,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=25,UserId=11,Rating=4,Review="nice",isLike=true},
            };

            Management management = new Management();

            // UC2
            //management.TopRecords(productReviewList);

            // UC3
            //management.SpecificRecords(productReviewList);

            // UC4
            //management.CountByRecords(productReviewList);

            // UC5 and UC7
            //management.RetrieveProductIDAndReview(productReviewList);

            // UC6
            //management.SkipRecords(productReviewList);

            // UC8
            //LinqToDataTable linqToDataTable = new LinqToDataTable();
            //linqToDataTable.AddToDatatable();

            // UC9 and UC10 and UC11 and UC12
            DataTableForProducts dataTableForProducts = new DataTableForProducts();
            dataTableForProducts.AddDataTable();

        }
    }
}