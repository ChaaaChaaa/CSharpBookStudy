using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9.PropertiesInAbstractClass
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Product product1 = new MyProduct()
            {
                ProductDate = new DateTime(2021, 4, 28)
            };

            Console.WriteLine("Product:{0}, Product DAte : {1}",
                product1.SerialID,
                product1.ProductDate);

            Product product2 = new MyProduct()
            {
                ProductDate = new DateTime(2021, 4, 28)
            };

            Console.WriteLine("Product : {0}, Product Date :{1}",
                product2.SerialID,
                product2.ProductDate);
        }
    }
}
