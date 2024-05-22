using AutoMapper;
using ClothesMarkt.Dtos;
using ClothesMarkt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.BLL.Managers.Abstract
{
	public interface IManager<TDto, TViewModel>
			where TDto : BaseDto
			where TViewModel : BaseViewModel
	{
		IMapper Mapper { set; }
		int Add(TViewModel viewmodel);
		int Update(TViewModel viewmodel);
		int Delete(int id);
		int Delete(TViewModel viewmodel);
		IEnumerable<TViewModel> GetAll();
		TViewModel? GetById(int id);
	}
}
