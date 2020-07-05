using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Interface;

namespace PromotionEngine
{
    public class Program
    {
        private readonly IProductService productService;

        public Program ()
        {
            this.productService = new ProductService();
        }
        static void Main(string[] args)

        {
            Program program = new Program();
            List<Product> products = new List<Product>();
            Console.WriteLine("Total number of orders:");
            int a = Convert.ToInt32(Console.ReadLine());
            int no = 1;
            for (int i = 0; i < a; i++)
            {
               
                Console.WriteLine("Enter the type of product:A,B,C or D for "+no+ " order");
                string input = Console.ReadLine();
                string type = input.ToUpper();
                Product p = program.productService.GetPriceByType(type);
                products.Add(p);
                no++;
            }
           int totalPrice = program.productService.GetTotalPrice(products);
           Console.WriteLine("Total : " + totalPrice);
           Console.ReadLine();
        }
    }
}

