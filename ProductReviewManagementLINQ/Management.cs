using System;
using System.Collections.Generic;
using System.Data;

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
    }
}
