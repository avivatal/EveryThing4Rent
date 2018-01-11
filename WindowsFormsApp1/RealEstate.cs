using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RealEstate: Product
    {
        string type;
        double capacity;
        public RealEstate(int productId, string lessorID, double rentalCost, string minimalRentTime, string approvalApproach, string isOnlyPartOfPackage, string cancelPolicy, string image, double deposit, double avgScore, double viewCount, string canBeTraded, string type,double capacity): base(productId, lessorID, rentalCost, minimalRentTime, approvalApproach, isOnlyPartOfPackage, cancelPolicy, image, deposit, avgScore, viewCount, canBeTraded)
        {
            this.type = type;
            this.capacity = capacity;
        }
    }
}
