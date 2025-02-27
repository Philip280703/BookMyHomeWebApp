using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Domain.Models
{
	public class Adresse
	{
		public Adresse() { }

		public int AdresseID { get; private set; }
		public int Postnummer { get; private set; }
		public string Vejnavn { get; private set; }
		public string Husnummer { get; private set; }
		public string Placering { get; private set; }
		public string Note {  get; private set; }

		public PostnummerOgBy ?PostnummerOgBy { get; private set; }

	}
}
