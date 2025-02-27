﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Domain.Models
{
	public class Bolig
	{
		public Bolig() { }

		public int BoligID { get; private set; }
		public string Title { get; private set; }
		public string Beskrivelse { get; private set; } = string.Empty;
		public int AdresseID { get; private set; }
		public double PrisPrNat { get; private set; }
		public int HostBrugerID { get; private set; }

		public List<Booking> BookingList { get; private set; } = new List<Booking>();
		public List<Anmeldelse> AnmeldelseList { get; private set; } = new List<Anmeldelse>();

		public Adresse ?Adresse { get; private set; }
		public Bruger ?bruger {  get; private set; }

	}
}
