using ClothesMarkt.BLL.Managers.Abstract;
using ClothesMarkt.DAL.Services.Concrete;
using ClothesMarkt.Dtos;
using ClothesMarkt.Entities;
using ClothesMarkt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.BLL.Managers.Concrete
{
	public class TshirtManager : Manager<TshirtDto, TshirtViewModel, Tshirt>
	{
		public TshirtManager(TshirtService service) : base(service)
		{
		}
	}
}
