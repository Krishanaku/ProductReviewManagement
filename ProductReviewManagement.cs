﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {

        public static void RetreiveTop3Records(List<ProductReview> list)
        {
            Console.WriteLine("\nUsing method Syntax");
            List<ProductReview> sortedInDesending = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProductReviews(sortedInDesending);
        }


        public static void FetchRecordsBasedOnRatingAndProductId(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(p => p.Rating > 3 && p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9).ToList();
            Program.DisplayProductReviews(result);
        }

        public static void FindingEachCountOfProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.Id + " ->  " + "Count: " + item.count);
            }
        }


        public static void DisplayProductIdAndReview(List<ProductReview> list)
        {
            var result = list.Select(p => new { Id = p.ProductId, Review = p.Review }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.Id + " ->  " + "Review: " + item.Review);
            }
        }

        public static void SkipTop5Records(List<ProductReview> list)
        {
            List<ProductReview> result = list.Skip(5).ToList();
            Program.DisplayProductReviews(result);
        }

        public static void FindRecordsWhoseIsLikeValueIsTrue(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(x => x.IsLike == true).OrderBy(x => x.IsLike).ToList();
            Program.DisplayProductReviews(result);
        }
        public static void FindAverageRecords(List<ProductReview> list)
        {
            var result = list.Average(p => p.Rating);
            Console.WriteLine("Average records are: {0}", result);
        }

        public static void FindRecordsContainMessageNice(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(p => p.Review.Contains("Nice")).ToList();
            Program.DisplayProductReviews(result);
        }

        public static void FindRecordsWhoseIdIs10(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(x => x.UserId == 10).OrderBy(x => x.Rating).ToList();
            Program.DisplayProductReviews(result);
        }
    }
}