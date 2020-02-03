using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;


namespace BLL
{
    public class ProductManager
    {
        public static List<Product> GetAll()
        {
            List<Product> products = null;
            products = ProductDAL.GetAll();
            return products;
        }

        public static Product GetBy(int id)
        {
            Product theProduct = null;
            theProduct = ProductDAL.Get(id);
            return theProduct;

        }
        public static List<Product> GetTop10()
        {
            List<Product> products = new List<Product>();
            //.......
            //.......

            return products;

        }
    }

}
