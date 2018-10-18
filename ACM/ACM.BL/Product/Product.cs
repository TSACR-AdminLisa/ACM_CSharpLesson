using Acme.Common;
using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        #region "Variables"

        private string _productName;

        #endregion

        #region "Constructors"
        public Product() : this(0)
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }
        #endregion

        #region "Properties"

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        #endregion

        #region "Functions"
        
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            return this.ProductId + ": " + 
                   this.ProductName + " " +
                   "Detail: " + this.ProductDescription + " " +
                   "Status: " + this.EntityState.ToString();
        }

        #endregion

    }
}
