using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Package: Product
    {
        public List<Product> products;
        public Package(int productId, string lessorID, double rentalCost, string minimalRentTime, string approvalApproach, string isOnlyPartOfPackage, string cancelPolicy, string image, double deposit, double avgScore, double viewCount, string canBeTraded): base(productId, lessorID, rentalCost, minimalRentTime, approvalApproach, isOnlyPartOfPackage, cancelPolicy, image, deposit, avgScore, viewCount, canBeTraded)
        {
            products = new List<Product>();
        }
        
    }
}
