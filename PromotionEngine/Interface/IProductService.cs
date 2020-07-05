using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interface
{
    public interface IProductService
    {
        Product GetPriceByType(string id);
        int GetTotalPrice(List<Product> products);
    }
}
