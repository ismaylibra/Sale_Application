using System;

namespace Sailing_Application_Delegate_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AVTODETAL Ehtiyyat Hisseleri");
            Product product = new Product("Bufer", 148);
            Product product1 = new Product("On Suse", 110);
            Product product2 = new Product("Suse Silen", 120.48);
            Product product3 = new Product("Teker (Sin)", 240.59);
            Product product4 = new Product("AntiFriz", 48.23);
            Order order = new Order();
            byte choose;
            do
            {
                int i = 0;
                Console.WriteLine($"{++i}.{product1}");
                Console.WriteLine("************");
                Console.WriteLine($"{++i}.{product2}");
                Console.WriteLine("************");
                Console.WriteLine($"{++i}.{product3}");
                Console.WriteLine("************");
                Console.WriteLine($"{++i}.{product4}");
                Console.WriteLine("************");
                Console.WriteLine($"{++i}. Ceki Cixart");
                Console.WriteLine("************");
                Console.Write("Menudan bir secenegi secin ");
                choose = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("************");
                switch (choose)
                {
                    case 1:
                        Console.Write($"Nece Dene  Almaq Isteyirsiniz {product1.Name} ? ");
                        product1.Count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");
                        Console.Clear();
                        order.Sell(product1);
                        break;
                    case 2:
                        Console.Write($"Nece Dene Almaq Isteyirsiniz {product2.Name} ? ");
                        product2.Count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");

                        Console.Clear();
                        order.Sell(product2);
                        
                        break;
                    case 3:
                        Console.Write($"Nece Dene Almaq Isteyirsiniz {product3.Name} ? ");
                        product3.Count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");
                        Console.Clear();

                        order.Sell(product3);
                        
                        break;
                    case 4:
                        Console.Write($"Nece Dene Almaq Isteyirsiniz {product4.Name} ? ");
                        product4.Count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");
                        Console.Clear();
                        order.Sell(product4);
                       
                        break;
                    case 5:
                        Console.Clear();
                        order.Cheking();
                        
                        break;
                    default:
                        Console.WriteLine("Select valid number");
                        break;
                }
            } while (choose != 0 && choose != 5);

        }
    }
}
