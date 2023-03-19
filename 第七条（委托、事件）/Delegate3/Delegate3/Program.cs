using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();
            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger log = new Logger();
            Action<Product> action = new Action<Product>(log.Log); 

            Box box1 = wrapFactory.WrapProduct(func1, action);
            Console.WriteLine(box1.Product.Name);
            Box box2 = wrapFactory.WrapProduct(func2, action);
            Console.WriteLine(box2.Product.Name);
        }
    }

    class Logger
    {
        public void Log(Product product) 
        {
            Console.WriteLine("Product'{0}' created at {1}.price is {2}",product.Name,DateTime.UtcNow, product.Price);
        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Box
    {
        public Product Product { get; set; }    
    }
    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct,Action<Product> log)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price>=50)
            {
                log.Invoke(product);
            }
            box.Product = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 23;
            return product;
        }

        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product;
        }
    }
}
