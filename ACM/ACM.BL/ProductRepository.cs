using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        #region "Functions"

        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "Assorted Siz";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save()
        {
            return true;
        }

        #endregion
    }
}
