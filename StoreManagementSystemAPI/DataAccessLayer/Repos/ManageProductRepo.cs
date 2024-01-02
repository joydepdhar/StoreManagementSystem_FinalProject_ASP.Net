using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class ManageProductRepo : Repo, IRepoCustomer<Product, int, string, int, Product>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Filter(int min, int max)
        {
            var products = db.Products.Where(p => p.Price >= min && p.Price <= max).ToList();
            return products;
        }


        public List<Product> GetOrderProductDetails(int id)
        {
            var userOrder = (from CustomerOrder in db.CustomerOrders
                             where CustomerOrder.CustomerID == id select CustomerOrder).FirstOrDefault();

            var order = (from CusOr in db.Orders
                         where CusOr.Id == userOrder.OrderID
                         select CusOr).FirstOrDefault();

            var productid = (from po in db.ProductOrders
                             where po.OrderID == order.Id
                             select po).FirstOrDefault();

            var Product = (from p in db.Products
                           where p.Id == productid.Id
                           select p).ToList();
            return Product;
        }

        public Product Created(Product obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string data)
        {
            var products = db.Products.Where(p => p.Name.Contains(data)).ToList();
            return products;
        }

        public Product Update(Product Obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetOrderProductDetails()
        {
            throw new NotImplementedException();
        }

        public Product GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductsInCart(int CustomerId)
        {
            var productsInCart = db.Carts
                                    .Where(c => c.CustomerID == CustomerId)
                                    .Select(c => c.Product)
                                    .ToList();

            return productsInCart;
        }
    }
}
