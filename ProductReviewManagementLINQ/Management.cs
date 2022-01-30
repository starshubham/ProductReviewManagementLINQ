using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReviewManagementLINQ
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        /* UC1:- Product Review Management
                     - Create Product review class with ProductID, UserID, Rating, Review and isLike fields.
                     - Create variable for List of Product Review class in Main method
                     - Add 25 default values in list which we have created.
        */
        public void IterateProductReview(List<ProductReview> productReviewlist)
        {
            foreach (ProductReview list in productReviewlist) //print list item
            {
                Console.WriteLine("ProductId:-" + list.ProductId + "  " + "UserId:-" + list.UserId + "  " + "Rating:-" + list.Rating
                    + "  " + "Review:-" + list.Review + "  " + "IsLike:-" + list.isLike); //Print data
            }
        }

        /* UC2:- Product Review Management.
                 - Retrieve top 3 records from the list who’s rating is high using LINQ.
        */
        public static void RetrieveTop3records(List<ProductReview> productReviewlist)
        {
            //Query syntax for LINQ
            var result = (from products in productReviewlist
                          orderby products.Rating descending
                          select products).Take(3);
            foreach (var elements in result)
            {
                Console.WriteLine($"ProductId:- {elements.ProductId} UserId:- {elements.UserId} Rating:- {elements.Rating} Review:- {elements.Review} isLike:- {elements.isLike}");
            }
        }
    }
}
