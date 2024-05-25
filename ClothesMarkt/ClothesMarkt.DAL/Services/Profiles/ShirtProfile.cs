using AutoMapper;
using ClothesMarkt.Dtos;
using ClothesMarkt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.DAL.Services.Profiles
{
	internal class ShirtProfile : Profile
	{
		public ShirtProfile()
		{
			CreateMap<ShirtDto, Shirt>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
			CreateMap<ShirtDto, Shirt>().ForMember(dest => dest.Renkler, opt => opt.MapFrom(src => src.Renkler));
			CreateMap<Shirt, ShirtDto>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
			CreateMap<Shirt, ShirtDto>().ForMember(dest => dest.Renkler, opt => opt.MapFrom(src => src.Renkler));

			CreateMap<CategoryDto, Category>().ReverseMap();
			CreateMap<RenkDto, Renk>().ReverseMap();
			CreateMap<ShirtsRenklerDto, ShirtsRenkler>().ReverseMap();


		}
	}
}
