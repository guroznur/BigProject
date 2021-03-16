using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted= "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Marka listelendi";

        public static string ColorAdded = "Color eklendi";
        public static string ColorDeleted = "Color silindi";
        public static string ColorUpdated = "Color güncellendi";
        public static string ColorsListed = "Renk listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = " Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";


        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalDenied = "Kiralama işlemi başarısız";
        public static string ReturnedRental = "Kiraladığınız araba teslim edildi";



        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string CarsListed = "Arababalar listelendi";

        public static string CarImagesDeleted = "Resim silindi";
        public static string CarImageUpdated = "Resim güncellendi";
        public static string CarImageAdded = "Resim eklendi";
        public static string CarNameAlreadyExists = "Bu İsimde başka bir araba mevcut";
        public static string  AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public  static string SuccessfulLogin = "Sisteme giriş başarılı";
    }
}
