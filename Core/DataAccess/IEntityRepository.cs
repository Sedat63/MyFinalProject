﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //Core: Evrensel projeleri barındırır. Bu nedenle.Net Core ile ilgisi yoktur!! 
{// Önemli: Core katmanı diğer katmanları referans almaz!!
	//generic constraint
	//class: referans tip
	//IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
	//new(): newlenebilir olmalı. 
	public interface IEntityRepository<T> where T:class,IEntity,new()
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null); //ürünleri filtrelemeye yarar
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);

		
	}
}
