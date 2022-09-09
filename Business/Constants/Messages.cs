using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Başarıyla eklendi";
        public static string NotAdded = "Ekleme işlemi gerçekleşmedi";
        public static string Deleted = "Başarıyla silindi";
        public static string Updated = "Başarıyla güncellendi";
        public static string Listed = "Başarıyla listelendi";
        public static string NameInvalid = "İsim geçersiz, lütfen kontrol edin";
        public static string DetailListed = "Detaylar listelendi";
        public static string CarImageLimitExceded = "En fazla 5 görsel ekleyebilirsiniz";
        public static string CarImageAdded = "Araba görseli eklendi";
        public static string FileNotExists = "Dosya bulunamadı.";
        public static string DefaultImageNotExists = "Dosya bulunamadı.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated="Access Token Oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
