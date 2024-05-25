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
	public class ShirtRepo : Repo<Shirt>
	{
		public ShirtRepo(ClothesMarktDbContext dbContext) : base(dbContext)
		{ }

		public override IEnumerable<Shirt> GetAll()
		{
			return _context.Shirts.Include(c => c.Category).AsNoTracking().ToList();
		}

		public override Shirt GetById(int id)
		{
			return _context.Shirts.Include(c => c.Category).AsNoTracking().SingleOrDefault(z => z.Id == id);
		}
	}
}
