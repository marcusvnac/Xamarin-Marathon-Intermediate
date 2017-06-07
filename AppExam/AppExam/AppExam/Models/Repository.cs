using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExam.Models
{
    public class Repository
    {
        public async Task<List<Coupon>> GetCoupons()
        {
            var service = new Services.AzureDataService<Coupon>();
            var items = await service.GetTable();
            return items.ToList();
        }
    }
}
