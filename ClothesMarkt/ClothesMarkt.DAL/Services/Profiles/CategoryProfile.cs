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
			CreateMap<Category, CategoryDto>().ForMember(dest => dest.Shirts, opt => opt.MapFrom(src => src.Shirts));
			CreateMap<CategoryDto, Category>().ForMember(dest => dest.Shirts, opt => opt.MapFrom(src => src.Shirts));

			CreateMap<Category, CategoryDto>().ForMember(dest => dest.Tshirts, opt => opt.MapFrom(src => src.Tshirts));
			CreateMap<CategoryDto, Category>().ForMember(dest => dest.Tshirts, opt => opt.MapFrom(src => src.Tshirts));

			CreateMap<CategoryDto, Category>().ReverseMap();
			CreateMap<TshirtDto, Tshirt>().ReverseMap();
			CreateMap<ShirtDto, Shirt>().ReverseMap();
		}
	}
}
