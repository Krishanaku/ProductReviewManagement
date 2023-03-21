using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void TopRecordList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " | UserId: " + list.UserId + " | Rating: " + list.Rating + " | Review: " + list.Review + " | Like: " + list.isLike);

            }
        }

        public void SelectRecordList(List<ProductReview> review)
        {
            var recordData = from productReviews in review
                              where (productReviews.ProductId ==1 && productReviews.Rating > 3) ||
                              (productReviews.ProductId == 4 && productReviews.Rating > 3) ||
                              (productReviews.ProductId == 9 && productReviews.Rating > 3)
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " | UserId: " + list.UserId + " | Rating: " + list.Rating + " | Review: " + list.Review + " | Like: " + list.isLike);

            }
        }

        public void RetrieveCount(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var record in recordData)
            {
                Console.WriteLine(record.ProductID + "--------"+ record.Count);
            }
        }




    }
}
