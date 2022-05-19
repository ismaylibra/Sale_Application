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


            do { 
            Menu:

                Console.WriteLine($"1.{product1}");
                Console.WriteLine("************");
                Console.WriteLine($"2.{product2}");
                Console.WriteLine("************");
                Console.WriteLine($"3.{product3}");
                Console.WriteLine("************");
                Console.WriteLine($"4.{product4}");
                Console.WriteLine("************");
                Console.WriteLine($"5. Ceki Cixart");
                Console.WriteLine("************");
                Console.Write("Menudan bir secenegi secin ");
            bool resultChoose = byte.TryParse(Console.ReadLine(), out choose);
                
            Console.WriteLine("************");
            try
            {
                if (resultChoose)
                {
                    goto AfterMenu;
                }
                else if(!resultChoose)
                {
                    goto Menu;
                }

            }
            catch (FormatException)
            {

                
            }
            AfterMenu:
                switch (choose)
                {   
                    case 1:
                    Case1Place:
                        Console.Write($"Nece Dene  Almaq Isteyirsiniz {product1.Name} ? ");
                        bool resultProduct1 = int.TryParse(Console.ReadLine(), out product1.Count);
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");
                        Console.Clear();
                        order.Sell(product1);
                        try
                        {
                            if (resultProduct1)
                            {
                                goto Menu;
                            }
                            else if (!resultProduct1)
                            {
                                goto AfterMenu;
                            }
                        }
                        catch (FormatException)
                        {

                            throw;
                        }
                        break;
                    case 2:
                    Case2Place:
                        Console.Write($"Nece Dene Almaq Isteyirsiniz {product2.Name} ? ");
                        bool resultProduct2 = int.TryParse(Console.ReadLine(), out product2.Count);
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");

                        Console.Clear();
                        order.Sell(product2);
                        try
                        {
                            if (resultProduct2)
                            {
                                goto Menu;
                            }
                            else if (!resultProduct2)
                            {
                                goto AfterMenu;
                            }
                        }
                        catch (FormatException)
                        {

                            throw;
                        }

                        break;
                    case 3:
                    Case3Place:
                        Console.Write($"Nece Dene Almaq Isteyirsiniz {product3.Name} ? ");
                        bool resultProduct3 = int.TryParse(Console.ReadLine(), out product3.Count);
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");
                        Console.Clear();

                        order.Sell(product3);
                        try
                        {
                            if (resultProduct3)
                            {
                                goto Menu;
                            }
                            else if (!resultProduct3)
                            {
                                goto AfterMenu;
                            }
                        }
                        catch (FormatException)
                        {

                            throw;
                        }

                        break;
                    case 4:
                    Case4Place:
                        Console.Write($"Nece Dene Almaq Isteyirsiniz {product4.Name} ? ");
                        bool resultProduct4 = int.TryParse(Console.ReadLine(), out product4.Count);
                        Console.WriteLine($"Umumi odenilecek mebleg: {Order.TotalPrice}");
                        Console.Clear();
                        order.Sell(product4);
                        try
                        {
                            if (resultProduct4)
                            {
                                goto Menu;
                            }
                            else if (!resultProduct4)
                            {
                                goto AfterMenu;
                            }
                        }
                        catch (FormatException)
                        {

                            throw;
                        }

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
