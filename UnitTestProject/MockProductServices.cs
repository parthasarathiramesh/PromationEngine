using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject.Models;

namespace UnitTestProject
{
    public class MockProductServices
    {
        public MockProduct GetPriceByType(string id)
        {
            MockProduct product = new MockProduct();
            product.Id = id;
            switch (product.Id)
            {
                case "A":
                    product.Price = 50;

                    break;
                case "B":
                    product.Price = 30;

                    break;
                case "C":
                    product.Price = 20;

                    break;
                case "D":
                    product.Price = 15;
                    break;

            }
            return product;
        }
        public int GetTotalPrice(List<MockProduct> mockproducts)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 10;
            foreach (MockProduct pr in mockproducts)
            {
                if (pr.Id == "A")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
