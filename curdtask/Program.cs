            using curdtask.Data;
            using curdtask.Model;

        namespace curdtask
        {
            internal class Program
            {

                static void Main(string[] args)
                {

                    ApplictionDbContext dbContext = new ApplictionDbContext();
           
                    List<Product> products = new List<Product>
                        {
                            new Product { Name = "Smartphone", Price = 699.99m },
                            new Product { Name = "Laptop", Price = 1299.99m },
                            new Product { Name = "Headphones", Price = 199.99m },
                            new Product { Name = "Smartwatch", Price = 299.99m },
                            new Product { Name = "Digital Camera", Price = 499.99m }
                        };

                    List<Order> orders = new List<Order>
                        {
                             new Order { Adress = "123 King Faisal Street, Ramallah" },
                        new Order { Adress = "456 Al-Quds Avenue, Jerusalem" },
                        new Order { Adress = "789 Al-Manara Square, Nablus" },
                        new Order { Adress = "101 Al-Rimal Street, Gaza" },
                        new Order { Adress = "202 Salah Al-Din Street, Hebron" }
                        };  
                    dbContext.products.AddRange(products);

                    dbContext.orders.AddRange(orders);

                    dbContext.SaveChanges();
                    Console.WriteLine("Done Add Data");
            
                            var GetAllProducts = dbContext.products.ToList();
                    Console.WriteLine("All Products:");
                    foreach (var product in GetAllProducts)
                    {
                        Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                    }

                    var GetAllOrders = dbContext.orders.ToList();
                    Console.WriteLine("All Orders:");
                    foreach (var order in GetAllOrders)
                    {
                        Console.WriteLine($"Id: {order.Id}, Adress: {order.Adress}, CreatedAt: {order.createdAt}");
                    }
           
          
                    var productsUpdate = dbContext.products.FirstOrDefault(p => p.Id == 2);
                    if (productsUpdate != null)
                    {
                    productsUpdate.Name = " Product new";
                        dbContext.SaveChanges();
                    }

                    var ordersUpdate = dbContext.orders.FirstOrDefault(o => o.Id == 3);
                    if (ordersUpdate != null)
                    {
                    ordersUpdate.createdAt = DateTime.Now.AddDays(-10);
                        dbContext.SaveChanges();
                    }
                Console.WriteLine("Done Update Data");

                var productRemove = dbContext.products.FirstOrDefault(p => p.Id == 2);
                    if (productRemove != null)
                    {
                        dbContext.products.Remove(productRemove);
                        dbContext.SaveChanges();
                    }
            
                    var orderRemove = dbContext.orders.FirstOrDefault(o => o.Id == 3);
                    if (orderRemove != null)
                    {
                        dbContext.orders.Remove(orderRemove);
                        dbContext.SaveChanges();
                    }

                Console.WriteLine("Done Remove Data");
         

            
                }
            }
        }
               
