using ClothesMarkt.DAL.Context;
using ClothesMarkt.DAL.Repositories.Abstract;
using ClothesMarkt.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.DAL.Repositories.Concrete
{
	public class CategoryRepo : Repo<Category>
	{
		public CategoryRepo(ClothesMarktDbContext dbContext) : base(dbContext)
		{ }
		public override IEnumerable<Category> GetAll()
		{
			return _context.Categories.Include(c => c.Products).ToList();
		}

		public override Category? GetById(int id)
		{
			return _context.Categories.Include(p => p.Products).Where(c => c.Id == id).AsNoTracking().SingleOrDefault();
		}

	}
}
