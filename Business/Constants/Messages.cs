using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInvalid = "Car name is invalid!";
        public static string MaintenenceTime = "The system under maintenence";
        public static string CarListed = "Cars have been listed";
        public static string CarAdded = "Car has been added.";
        public static string CarNotAdded = "Car could not added!";
        public static string CarDeleted = "Car has been deleted.";
        public static string CarNotDeleted = "Car could not deleted.";
        public static string CarUpdated = "Car has been updated.";
        public static string CarNotUpdated = "Car could not updated.";

        public static string BrandAdded = "Brand has been added.";
        public static string BrandNotAdded = "Brand could not added!";
        public static string BrandDeleted = "Brand has been deleted.";
        public static string BrandListed = "Brands have been listed";

        public static string UserListed = "Users have been listed";
        public static string UserAdded = "User has been added.";
        public static string UserInvalid = "User is invalid! There are some empty properties.";
        public static string UserUpdated = "User has been updated.";

        public static string RentalCarDidNotReturn = "The car did not return yet. Select another car.";
        public static string Rented = "The car has been rented.";
        public static string RentalCarReturned = "The car returned successfully.";
    }
}
