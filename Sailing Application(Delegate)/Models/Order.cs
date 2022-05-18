using System;
using System.Collections.Generic;
using System.Text;
using static Sailing_Application_Delegate_.Order;

namespace Sailing_Application_Delegate_
{
    class Order
    {
        public List<Product> Products;
        public static double TotalPrice;
        public DateTime Date;   
        static Order()
        {
            TotalPrice = 0;
        }
        public Order( )
        {
            Products = new List<Product>();

            Date = DateTime.Now;
            
        }
        public void Cheking()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"Mehsul adi: {product.Name} \nMehsul Qiymeti: {product.Price} Mehsul  Sayi: {product.Count}");
                TotalPrice += product.Price * product.Count;
            }
            Console.WriteLine($"Total Qiymet: {TotalPrice}");
            Predicate<double> less100 = TotalPrice => TotalPrice < 100;
            Predicate<double> less200 = TotalPrice => TotalPrice >= 100 && TotalPrice < 200;
            Predicate<double> more200 = TotalPrice => TotalPrice >= 200;
            if (less100(TotalPrice))
            {
                Console.WriteLine("Endirim yoxdur");
                Console.WriteLine($"Odenilecek mebleg: {TotalPrice}" );
            }
            else if (less200(TotalPrice))
            {
                TotalPrice -= TotalPrice *0.1;
                Console.WriteLine($"Odenilecek mebleg: {TotalPrice} Endirim: 10%");
            }
            else if (more200(TotalPrice))
            {
                TotalPrice -= TotalPrice * 0.2;
                Console.WriteLine($"Odenilecek mebleg: {TotalPrice} Endirim: 20%");
            }
            Console.WriteLine($"Tarix: {Date}");

        }
        public void Sell(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product sayi: {product.Count} Elave olunan Mehsul: {product.Name}");
        }
       
    }



}


      

    


    

