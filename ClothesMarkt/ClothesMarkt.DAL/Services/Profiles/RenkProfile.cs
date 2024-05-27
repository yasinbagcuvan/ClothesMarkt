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
	public class RenkProfile : Profile
	{
		public RenkProfile()
		{
			CreateMap<RenkDto, Renk>().ForMember(dest => dest.Shirts, opt => opt.MapFrom(src => src.Shirts));
			CreateMap<Renk, RenkDto>().ForMember(dest => dest.Shirts, opt => opt.MapFrom(src => src.Shirts));
			CreateMap<RenkDto, Renk>().ForMember(dest => dest.Tshirts, opt => opt.MapFrom(src => src.Tshirts));
			CreateMap<Renk, RenkDto>().ForMember(dest => dest.Tshirts, opt => opt.MapFrom(src => src.Tshirts));
		
			CreateMap<RenkDto, Renk>().ReverseMap();
			CreateMap<CategoryDto, Category>().ReverseMap();
			CreateMap<ShirtDto, Shirt>().ReverseMap();
			CreateMap<TshirtDto, Tshirt>().ReverseMap();

			CreateMap<ShirtsRenklerDto, ShirtsRenkler>().ReverseMap();
			CreateMap<TshirtsRenkler, TshirtsRenklerDto>().ReverseMap();


		}
	}
}
