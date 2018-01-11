using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vehicle:Product
    {
        string type;
        string model;
        string manufacture;
        double yearOfManufacture;
        string isAutomatic;
        public Vehicle(int productId, string lessorID, double rentalCost, string minimalRentTime, string approvalApproach, string isOnlyPartOfPackage, string cancelPolicy, string image, double deposit, double avgScore, double viewCount, string canBeTraded,string type,string model,string manufacture,double yearOfManufacture,string isAutomatic): base(productId, lessorID, rentalCost, minimalRentTime, approvalApproach, isOnlyPartOfPackage, cancelPolicy, image, deposit, avgScore, viewCount, canBeTraded)
        {
            this.type = type;
            this.model=model;
            this.manufacture=manufacture;
            this. yearOfManufacture=yearOfManufacture;
            this. isAutomatic=isAutomatic;
        }
    }
}
