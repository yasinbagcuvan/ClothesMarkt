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
	public class TshirtProfile : Profile
	{
		public TshirtProfile()
		{
			CreateMap<TshirtDto, Tshirt>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
			CreateMap<TshirtDto, Tshirt>().ForMember(dest => dest.Renkler, opt => opt.MapFrom(src => src.Renkler));
			CreateMap<Tshirt, TshirtDto>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
			CreateMap<Tshirt, TshirtDto>().ForMember(dest => dest.Renkler, opt => opt.MapFrom(src => src.Renkler));

			CreateMap<CategoryDto, Category>().ReverseMap();
			CreateMap<RenkDto, Renk>().ReverseMap();
			CreateMap<TshirtsRenklerDto, TshirtsRenkler>().ReverseMap();
			

	
		}
	}
}
