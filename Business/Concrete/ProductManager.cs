﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
	// Manager= iş katmanına aittir.
		
	public class ProductManager : IProductService
	{
		IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public List<Product> GetAll()
		{
			//İş kodları
			//Yetkisi var mı?
			return _productDal.GetAll();

		}
	}
}