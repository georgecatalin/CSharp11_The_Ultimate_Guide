using ExtensionMethods;
using System;


namespace ExtensionMethod
{
    public static  class Extension
    {
        public static double GetTotalDiscount(this Product product )
        {
            return product.ProductCosting * product.DiscountPercentage;
        }


    }
}
