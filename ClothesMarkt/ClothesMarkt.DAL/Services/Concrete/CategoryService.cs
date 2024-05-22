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
	public class CategoryService : Service<Category, CategoryDto>
	{
		public CategoryService(CategoryRepo categoryRepo) : base(categoryRepo)
		{
			MapperConfiguration config = new MapperConfiguration(config =>
			{
				Profile profile = new CategoryProfile();
				config.AddProfile(profile);
			});

			base.Mapper = config.CreateMapper();
		}

	}
}
