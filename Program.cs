namespace ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem ");

            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() {ProductId =1, UserId=1, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =2, UserId=1, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =3, UserId=2, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =4, UserId=2, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =5, UserId=3, Rating=2, Review= "Bad", isLike=true},
                new ProductReview() {ProductId =6, UserId=4, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =1, UserId=3, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =2, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =5, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =12, UserId=10, Rating=2, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =6, UserId=10, Rating=3, Review= "Nice", isLike=true},
                new ProductReview() {ProductId =3, UserId=10, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =2, UserId=10, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =5, UserId=10, Rating=3, Review= "Nice", isLike=true}
            };

            foreach (var list in productReviews)
            {
                Console.WriteLine("Product Id:" + list.ProductId + "UserId: " + list.UserId + "Rating:" + list.Rating + "Review:" + list.Review + "Like: " + list.isLike);

            }



        }
    }
}