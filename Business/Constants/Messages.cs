using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
using Entities.Conrete;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNamedValid = "Araç ismi geçersiz";
        public static string MaintenanceTime="Site bakımda";
        public static string CarListed="Araçlar listelendi";
        public static string CarDeleted="Araç silindi";
        public static string CarUpdated="Araç güncellendi";
        public static string ColorAdded="Renk eklendi";
        public static string ColorDeleted="Renk silindi";
        public static string ColorListed="Renkler listelendi";
        public static string ColorUpdated="Renk güncellendi";
        public static string BrandAdded= "Marka eklendi";
        public static string BrandDeleted="Marka silindi";
        public static string BrandListed="Markalar listelendi";
        public static string BrandUpdated="Marka güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserUpdated="Kullanıcı güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerUpdated= "Müşteri güncellendi";
        public static string RentalAdded = "Kira bilgisi eklendi";
        public static string RentalDeleted = "Kira bilgisi silindi";
        public static string RentalUpdated= "Kira bilgisi güncellendi";
        public static string RentalListed = "Kira bilgisi listelendi";
        public static string CarNotAvailable="araç uygun değil";
        public static string CarAvailable="araç uygun";
        public static string CarImageLimitExceeded;
        public static string UserRegistered;
        public static string UserNotFound;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;

        public static string AuthorizationDenied { get; internal set; }
    }
}
