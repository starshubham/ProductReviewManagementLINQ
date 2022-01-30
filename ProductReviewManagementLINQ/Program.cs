using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagementLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
               new ProductReview() { ProductId = 1, UserId = 1, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 1, UserId = 2, Rating = 2, Review = "Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "Good", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 5, UserId = 5, Rating = 6, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 6, UserId = 10, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 7, UserId = 6, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 6, UserId = 5, Rating = 2, Review = "Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 9, UserId = 10, Rating = 5, Review = "Good", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 10, UserId = 41, Rating = 6, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 11, UserId = 5, Rating = 4, Review = "Nice", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 12, UserId = 4, Rating = 1, Review = "Very Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 11, UserId = 10, Rating = 0, Review = "Excelent", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 14, UserId =41, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 11, UserId = 51, Rating = 4, Review = "Nice", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 16, UserId = 8, Rating = 1, Review = "Very Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 17, UserId = 10, Rating = 7, Review = "Excelent", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 22, UserId = 9, Rating = 5, Review = "Good", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 19, UserId = 10, Rating = 4, Review = "Nice", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 20, UserId = 7, Rating = 3, Review = "Average", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 21, UserId = 6, Rating = 2, Review = "Bad", isLike = true }, //Adding Data
               new ProductReview() { ProductId = 22, UserId = 5, Rating = 1, Review = "Very Bad", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 23, UserId = 10, Rating = 5, Review = "Good", isLike = false }, //Adding Data
               new ProductReview() { ProductId = 22, UserId = 8, Rating = 2, Review = "Bad", isLike = true }, //Adding Date
               new ProductReview() { ProductId = 22, UserId = 12, Rating = 3, Review = "Average", isLike = false }, //Adding Data
              
            };
            //CreateDataTable(); 

            //UC1
            //Management management = new Management();  //Creating Object of Management class
            //management.IterateProductReview(productReviewlist);

            //UC2
            //Management.RetrieveTop3records(productReviewlist);

            //UC3
            //Management.RetrieveRecordsWithGreaterThanThreeRating(productReviewlist);

            //UC4
            //Management.RetrieveCountOfReviewForEachProductId(productReviewlist);

            //UC5
            //Management.RetrieveProductIDAndReviewOfAllRecords(productReviewlist); 

            //UC6
            //Management.SkipTopFiveRecords(productReviewlist); 

            //UC7
            //Management.RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist); 

            //UC8
            //Management.CreateDataTable();

            //UC9
            //Management.RetrieveRecordWithTrueIsLike(); 

            //UC10
            //Management.FindAverageRatingOfTheEachProductId();

            //UC11
            //Management.RetrieveRecordsWithReviewContainsNice();

            //UC12
            Management.RetrieveRecordsForGivenUserIdOrderByRating(); 
        }


        /* Class Program*/
        public static void CreateDataTable() //create method
        {
            DataTable table = new DataTable(); //create table and create object
            table.Columns.Add("ProductId");     // add Columns in table
            table.Columns.Add("ProductName"); // add Columns in table

            table.Rows.Add("1", "Laptop"); //add rows on table
            table.Rows.Add("2", "Mobile");
            table.Rows.Add("3", "Tablet");
            table.Rows.Add("4", "Desktop");
            table.Rows.Add("5", "Watch");
            DisplayTableProduct(table);

        }
        public static void DisplayTableProduct(DataTable table) //Create DisplayTableProduct method
        {
            var Productname = from product in table.AsEnumerable() select product.Field<string>("ProductName"); //Fetch Products of the table
            foreach (var item in Productname) //Iterate 
            {
                Console.WriteLine($"ProductName:- {item}"); //print 
            }
        }
    }
}
