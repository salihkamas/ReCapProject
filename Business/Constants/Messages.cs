using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Maintenance Time";
        public static string SuccesListed = "Successfully Listed";
        public static string SuccesUpdated = "Successfully Updated";
        public static string CarNameInvalid = "Car name is invalid";
        public static string CarDailyPriceInvalid = "Car daily price is invalid";
        public static string SuccesDeleted = "Successfully Deleted";
        public static string SuccesAdded = "Successfully Added";
        public static string ErrorAdded = "Adding Failed";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successfully Login";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Acces token created";
        public static string AuthorizationDenied = "Authorization Denied";
    }
}
