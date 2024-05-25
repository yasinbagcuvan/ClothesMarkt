using AutoMapper;
using ClothesMarkt.DAL.Repositories.Concrete;
using ClothesMarkt.DAL.Services.Abstract;
using ClothesMarkt.DAL.Services.Profiles;
using ClothesMarkt.Dtos;
using ClothesMarkt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.DAL.Services.Concrete
{
	public class TshirtService : Service<Tshirt, TshirtDto>
	{
		public TshirtService(TshirtRepo tshirtRepo) : base(tshirtRepo)
		{
			MapperConfiguration config = new MapperConfiguration(config =>
			{
				Profile profile = new TshirtProfile();
				config.AddProfile(profile);
			});

			base.Mapper = config.CreateMapper();
		}
	}
}
