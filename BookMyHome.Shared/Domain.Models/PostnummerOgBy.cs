using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Domain.Models
{
	public class PostnummerOgBy
	{
		[Key]
		public int Postnummer { get; private set; }
		public string Bynavn { get; private set; }

	}
}
