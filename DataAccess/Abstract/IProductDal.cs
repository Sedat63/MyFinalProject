using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	//İlk önce interfacesini oluştur. IProductDal ne demektir?
	// I = interface, Product = Veritabanında hangi tablo olduğunu, Dal = Hangi katmana karşılık geldiğini
	//DAL = Data Access Layer
	public interface IProductDal:IEntityRepository<Product>
	//Interface nin kendisi default public olmadığından public eklenir
	//Interface metodları default public olduğundan public eklenmez.
	{
		List<ProductDetailDto> GetProductDetails();
	}
}
