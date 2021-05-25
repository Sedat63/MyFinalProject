using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>//hangi tabloyu verirsek
		where TEntity : class, IEntity, new() //onun için IEntityRepository interfacesinin içindeki fonk.ları yapıyor
		where TContext : DbContext, new() //yani T parametresinin içerisinde Entity gidiyor
	{
		public void Add(TEntity entity)
		{
			//IDisposable pattern implementation of C#
			//Garbage collection belleği hızlı temizler
			using (TContext context = new TContext())
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var deletedEntity = context.Entry(entity);
				deletedEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (TContext context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			using (TContext context = new TContext())
			{
				//filter eğer null ise soru işaretinden sonraki kısım çalışır.
				//filter null değilse : (iki noktadan) sonraki kısım çalışır.			
				
				return filter == null
					? context.Set<TEntity>().ToList()
					: context.Set<TEntity>().Where(filter).ToList();
			}
		}

		public void Update(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var updatedEntity = context.Entry(entity);
				updatedEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
