using ClothesMarkt.DAL.Context;
using ClothesMarkt.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClothesMarkt.DAL.Repositories.Abstract.IRepo;

namespace ClothesMarkt.DAL.Repositories.Abstract
{
	public abstract class Repo<TEntity> : IRepo<TEntity> where TEntity : BaseEntity
	{
		protected ClothesMarktDbContext _context;
		protected DbSet<TEntity> entities;
		protected Repo(ClothesMarktDbContext context)
		{
			_context = context;

			//_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;

			entities = _context.Set<TEntity>();
		}

		public int Add(TEntity entity)
		{
			_context.Entry(entity).State = EntityState.Added;
            entities.Add(entity);
			 _context.SaveChanges();	
			return  entity.Id;
		}

		public int Delete(TEntity entity)
		{
			_context.Entry(entity).State = EntityState.Deleted;
			entities.Remove(entity);
			return _context.SaveChanges();
		}

		public virtual IEnumerable<TEntity> GetAll()
		{
			return _context.Set<TEntity>().AsNoTracking().ToList();
		}

		public virtual TEntity? GetById(int id)
		{

			return _context.Set<TEntity>().AsNoTracking().FirstOrDefault(x => x.Id == id);
		}

		public async virtual Task<TEntity>? GetByIdAsync(int id)
		{
			return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		}

		public int Update(TEntity entity)
		{

			//TEntity orjinal = this.GetById(entity.Id);
			//entity.Created = orjinal.created;
			//entity.Updated = DateTime.Now;
			_context.Entry(entity).State = EntityState.Modified;


			_context.Update(entity);
			return _context.SaveChanges();
		}
	}
}
