using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	//İlk önce interfacesini oluştur. IProductDal ne demektir?
	// I = interface, Product = Veritabanında hangi tablo olduğunu, Dal = Hangi katmana karşılık geldiğini
	//DAL = Data Access Layer
	public interface IProductDal //Interface nin kendisi default public olmadığından public eklenir
	{
		//Interface metodları default public olduğundan public eklenmez.
		List<Product> GetAll();
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);

		List<Product> GetAllByCategory(int categoryId); //ürünleri kategoriye göre filtrele
	}
}
