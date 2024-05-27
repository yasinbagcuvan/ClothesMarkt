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
	public class RenkRepo : Repo<Renk>
	{
		public RenkRepo(ClothesMarktDbContext dbContext) : base(dbContext)
		{ }
		public override IEnumerable<Renk> GetAll()
		{
			return _context.Colors.Include(c => c.Tshirts).Include(c => c.Shirts).AsNoTracking().ToList();
		}

		public override Renk GetById(int id)
		{
			return _context.Colors.Include(c => c.Tshirts).Include(c => c.Shirts).AsNoTracking().SingleOrDefault(z => z.Id == id);
		}
	}
}
