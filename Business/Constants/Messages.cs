using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Ürün eklendi";
		public static string ProductNameInvalid = "Ürün ismi geçersiz";
		public static string MaintenanceTime = "Sistem bakımda";
		public static string ProductsListed = "Ürünler listelendi";
		public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabilir.";
		public static string ProductNameAlreadyExists = "Aynı isimde başka bir ürün var.";
		public static string CategoryLimitExceded = "Kategori limiti aşıldı";
		public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır";
		public static string UserRegistered = "Kullanıcı kayıt oldu";
		public static string UserNotFound = "Kullanıcı bulunamadı";
		public static string PasswordError = "Parola hatalı";
		public static string SuccessfulLogin = "Giriş Başarılı";
		public static string UserAlreadyExists = "Kullanıcı zaten var";
		public static string AccessTokenCreated = "Token oluşturuldu";
	}
}
