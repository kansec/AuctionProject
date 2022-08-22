using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static readonly string AuctionAdded = "Auction added.";
        public static readonly string AuctionRemoved = "Auction removed.";
        public static readonly string AuctionUpdated = "Auction updated.";

        public static readonly string CarAdded = "Car added.";
        public static readonly string CarRemoved = "Car removed.";
        public static readonly string CarUpdated = "Car updated.";

        public static readonly string BidAdded = "Bid added.";
        public static readonly string BidRemoved = "Bid removed.";
        public static readonly string BidUpdated = "Bid updated.";
        public static readonly string AuthorizationDenied = "You are not authorized!";
        public static readonly string UserRegistered = "User registered.";
        public static readonly string UserNotFound = "User not found!";
        public static readonly string PasswordError = "Wrong password!";
        public static readonly string SuccessfulLogin = "Login successfull.";
        public static readonly string UserAlreadyExists = "User already exists!";
        public static readonly string AccessTokenCreated = "Access token created.";
    } 
}
