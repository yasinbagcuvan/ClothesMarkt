using ClothesMarkt.Enums.OrtakEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public int? RowNum { get; set; }
		public DateTime Created { get; set; } = DateTime.Now;
		public DateTime? Updated { get; set; }
		
	}
}
