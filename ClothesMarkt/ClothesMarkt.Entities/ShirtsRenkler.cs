using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public class ShirtsRenkler : BaseEntity
	{

		public int ShirtsId { get; set; }
		public Shirt Shirt { get; set; }


		public int RenklerId { get; set; }

		
		public Renk Renk { get; set; }
	}

	//public class RenkShirt
	//{
 //       public int ShirtsId { get; set; }
 //       public Shirt Shirt { get; set; }

 //       public int RenklerId { get; set; }

 //       [ForeignKey("RenklerId")]
 //       public Renk Renk { get; set; }
 //   }

	//public class RenkTshirt
	//{
 //       public int TshirtsId { get; set; }
 //       public Tshirt Tshirt { get; set; }

 //       public int RenklerId { get; set; }

 //       [ForeignKey("RenklerId")]
 //       public Renk Renk { get; set; }
 //   }
}
