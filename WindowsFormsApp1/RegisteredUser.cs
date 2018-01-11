using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RegisteredUser
    {
        public List<Product> myProducts;
        Product[] rentedProducts;
        string firstName;
        string surName;
        string id;
        string phoneNumber;
        string email;
        string password;
        string image;
        DateTime dateOfBirth;
        string paypalAcount;
        string isDangerous;
        string authorazations;
        double avgScore;
        string isReligous;
        
        public RegisteredUser(string id,string firstName, string surName, string phoneNumber, string email, string image, string paypalAcount, string isReligous)//,DateTime dateOfBirth)
        {
            //this.dateOfBirth = dateOfBirth;
            this.id = id;
            this.firstName = firstName;
            this.surName = surName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.image = image;
            this.paypalAcount = paypalAcount;
            this.isReligous = isReligous;
        }
        public Product getProductById(int id)
        {
           foreach(Product p in this.myProducts){
                if (p.productId==id)
                    return p;
            }
            return null;
        }
        public string getID()
        {
            return id;
        }
        public void changePassword(string oldPassword,string newPassword)
        {
            if(oldPassword.Equals(oldPassword))
            {
                password = newPassword;
            }
        }
        public void updateRating(double score)
        {

        }
        public void updateDetails(string firstName,string surName,string phoneNumber, string email,string image,DateTime dateOfBirth,string paypalAcount,bool isReligous)
        {

        }
        public void deleteAccount(string password)
        {

        }
        public void openChat(string id)
        {

        }
        public void leaveFeedback(string id)
        {

        }


    }
}
