﻿using System;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program");

            List<ProductReview> productreview = new List<ProductReview>()
            {
              new ProductReview() {ProductID = 1, UserID = 1, Rating = 5, Review = " Good", isLike = true},
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Bad", isLike = true},
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 1, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 2, Rating = 5, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 4, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 1, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 11, Rating = 4, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 2, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 2, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 4, Rating = 5, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 5, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
            };
            foreach (var list in productreview)
            {
                Console.WriteLine("ProductId:" + list.ProductID + " " + "UserID:" + list.UserID + " " + "Rating:" + list.Rating + " " + "Review:" + list.Review + " " + "isLike:" + list.isLike);
            }

            // Management management = new Management();
            //management.TopRecordList(productreview);

            // management.SelectedRecords(productreview);
            //  management.RetrieveCountOfRecords(productreview);
        }
            
    }
    
}
