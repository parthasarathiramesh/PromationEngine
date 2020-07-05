using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        // Testing 3 of A's
        [TestMethod]
        public void ThreeofA()
        {
            MockProductServices mockProductServices = new MockProductServices();
            List<MockProduct> products = new List<MockProduct>();
            int orders = 3;
            for (int i = 0; i < orders; i++)
            {
                string input = "A";
                string type = input.ToUpper();
                MockProduct p = mockProductServices.GetPriceByType(type);
                products.Add(p);
            }
            int totalPrice = mockProductServices.GetTotalPrice(products);

            Assert.AreEqual(130, totalPrice);

        }
        //Testing 2 of B's
        [TestMethod]
        public void TowofB()
        {
            MockProductServices mockProductServices = new MockProductServices();
            List<MockProduct> products = new List<MockProduct>();
            int orders = 2;
            for (int i = 0; i < orders; i++)
            {
                string input = "B";
                string type = input.ToUpper();
                MockProduct p = mockProductServices.GetPriceByType(type);
                products.Add(p);
            }
            int totalPrice = mockProductServices.GetTotalPrice(products);

            Assert.AreEqual(45, totalPrice);

        }
        //Testing C&D
        [TestMethod]
        public void CandD()
        {
            MockProductServices mockProductServices = new MockProductServices();
            List<MockProduct> products = new List<MockProduct>();
            List<string> inputs = new List<string>();
            inputs.Add("C");
            inputs.Add("D");

            foreach (var item in inputs)
            {
                MockProduct p = mockProductServices.GetPriceByType(item);
                products.Add(p);
            }
           
            int totalPrice = mockProductServices.GetTotalPrice(products);

            Assert.AreEqual(30, totalPrice);

        }
        //Testing Scenario A
        [TestMethod]
        public void ScenarioA()
        {
            MockProductServices mockProductServices = new MockProductServices();
            List<MockProduct> products = new List<MockProduct>();
            List<string> inputs = new List<string>();
            inputs.Add("A");
            inputs.Add("B");
            inputs.Add("C");

            foreach (var item in inputs)
            {
                MockProduct p = mockProductServices.GetPriceByType(item);
                products.Add(p);
            }

            int totalPrice = mockProductServices.GetTotalPrice(products);

            Assert.AreEqual(100, totalPrice);

        }
        //Testing Scenario B
        [TestMethod]
        public void ScenarioB()
        {
            MockProductServices mockProductServices = new MockProductServices();
            List<MockProduct> products = new List<MockProduct>();
            List<string> inputs = new List<string>();
            inputs.Add("A");
            inputs.Add("A");
            inputs.Add("A");
            inputs.Add("A");
            inputs.Add("A");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("C");

            foreach (var item in inputs)
            {
                MockProduct p = mockProductServices.GetPriceByType(item);
                products.Add(p);
            }

            int totalPrice = mockProductServices.GetTotalPrice(products);

            Assert.AreEqual(370, totalPrice);

        }
        //Testing Scenario C
        [TestMethod]
        public void ScenarioC()
        {
            MockProductServices mockProductServices = new MockProductServices();
            List<MockProduct> products = new List<MockProduct>();
            List<string> inputs = new List<string>();
            inputs.Add("A");
            inputs.Add("A");
            inputs.Add("A");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("B");
            inputs.Add("C");
            inputs.Add("D");
            

            foreach (var item in inputs)
            {
                MockProduct p = mockProductServices.GetPriceByType(item);
                products.Add(p);
            }

            int totalPrice = mockProductServices.GetTotalPrice(products);

            Assert.AreEqual(280, totalPrice);

        }
    }
}
