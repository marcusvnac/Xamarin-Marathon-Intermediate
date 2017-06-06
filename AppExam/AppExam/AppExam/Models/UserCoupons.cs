namespace AppExam.Models
{
    public class UserCoupon
    {
        public string CouponType { get; set; }
        public int Amount { get; set; }

        public UserCoupon(string couponType, int amount)
        {
            CouponType = couponType;
            Amount = amount;
        }
    }
}
