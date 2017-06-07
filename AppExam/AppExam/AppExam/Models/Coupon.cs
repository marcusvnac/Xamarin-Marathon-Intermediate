using Microsoft.WindowsAzure.MobileServices;

namespace AppExam.Models
{
    public class Coupon
    {

        public string Id { get; set; }

        public string CouponType { get; set; }

        public int Amount { get; set; }

        [Version]
        public string AzureVersion { get; set; }
    }
}
