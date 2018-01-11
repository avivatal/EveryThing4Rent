using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SecondHandProduct: Product
    {
        string subCategory;
        string condition;
        public SecondHandProduct(int productId, string lessorID, double rentalCost, string minimalRentTime, string approvalApproach, string isOnlyPartOfPackage, string cancelPolicy, string image, double deposit, double avgScore, double viewCount, string canBeTraded, string subCategory,string condition): base(productId, lessorID, rentalCost, minimalRentTime, approvalApproach, isOnlyPartOfPackage, cancelPolicy, image, deposit, avgScore, viewCount, canBeTraded)
        {
            this.subCategory = subCategory;
            this.condition = condition;
        }
    }
}
