using ClothesMarkt.Enums.OrtakEnums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Dtos
{
	public abstract class BaseDto
	{
		public int Id { get; set; }
        public int? RowNum { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
		public DateTime? Updated { get; set; }

	}
}
