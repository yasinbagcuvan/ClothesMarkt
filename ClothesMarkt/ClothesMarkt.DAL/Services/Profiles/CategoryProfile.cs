using AutoMapper;
using ClothesMarkt.DAL.Repositories.Concrete;
using ClothesMarkt.DAL.Services.Abstract;
using ClothesMarkt.Dtos;
using ClothesMarkt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.DAL.Services.Profiles
{
	public class CategoryProfile : Profile
	{
		public CategoryProfile()
		{
			CreateMap<Category, CategoryDto>().ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
			CreateMap<CategoryDto, Category>().ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
			CreateMap<CategoryDto, Category>().ReverseMap();
			CreateMap<ProductDto, Product>().ReverseMap();
		}
	}
}
