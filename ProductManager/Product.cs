using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    /// <summary>
    /// Represents a product for sale
    /// </summary>
    public class Product
    {
        // Constructor to force name to be passed in
        // when creating the object
        //public Product(string productName)
        //{
        //    Name = productName;
        //}

        /// <summary>
        /// A unique identifier for the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user facing name of the product
        /// </summary>
        public required string Name { get; set; }

        #region Fully Implemented Property sample
        //// Fully implemented C# property
        //private int _id;

        //public int ProductId
        //{
        //    get
        //    {
        //        return _id;
        //    }
        //    set
        //    {
        //        _id = value;
        //    }
        //}
        #endregion
    }
}
