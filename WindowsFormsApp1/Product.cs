using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Product 
    {
        public int productId;
        string lessorID;
        double rentalCost;
        string minimalRentTime;
        string approvalApproach;
        string isOnlyPartOfPackage;
        string cancelPolicy;
        string image;
        double deposit;
        double avgScore;
        double viewCount;
        string canBeTraded;
        public Product(int productId,string lessorID, double rentalCost, string minimalRentTime, string approvalApproach, string isOnlyPartOfPackage,string cancelPolicy,    string image,double deposit,double avgScore,double viewCount,   string canBeTraded)
        {
            this.productId = productId;
            this.lessorID = lessorID;
            this.rentalCost = rentalCost;
            this.minimalRentTime = minimalRentTime;
            this.approvalApproach = approvalApproach;
            this.isOnlyPartOfPackage = isOnlyPartOfPackage;
            this.cancelPolicy = cancelPolicy;
            this.image = image;
            this.deposit = deposit;
            this.avgScore = avgScore;
            this.viewCount = viewCount;
            this.canBeTraded=canBeTraded;

        }
        public int getID()
        {
            return productId;
        }
    }
}
