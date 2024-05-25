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
	public class TshirtRepo : Repo<Tshirt>
	{
		public TshirtRepo(ClothesMarktDbContext dbContext) : base(dbContext)
		{ }

		public override IEnumerable<Tshirt> GetAll()
		{
			return _context.Tshirts.Include(c => c.Category).AsNoTracking().ToList();
		}

		public override Tshirt GetById(int id)
		{
			return _context.Tshirts.Include(c => c.Category).AsNoTracking().SingleOrDefault(z => z.Id == id);
		}
	}
}
