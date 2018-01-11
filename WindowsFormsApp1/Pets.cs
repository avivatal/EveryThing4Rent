using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pets:Product
    {
        string animalType;
        string gender;
        double age;
        string breed;
        public Pets(int productId, string lessorID, double rentalCost, string minimalRentTime, string approvalApproach, string isOnlyPartOfPackage, string cancelPolicy, string image, double deposit, double avgScore, double viewCount, string canBeTraded, string animalType,string gender, double age,string breed): base(productId, lessorID, rentalCost, minimalRentTime, approvalApproach, isOnlyPartOfPackage, cancelPolicy, image, deposit, avgScore, viewCount, canBeTraded)
        {
            this.animalType = animalType;
            this.gender = gender;
            this.age = age;
            this.breed = breed;
        }
    }
}
