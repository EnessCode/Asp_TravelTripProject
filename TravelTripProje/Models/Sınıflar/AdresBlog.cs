﻿using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Sınıflar
{
	public class AdresBlog
	{
        [Key]
        public int ID { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public string AdresAcik { get; set; }
		public string Mail { get; set; }
		public string Telefon { get; set; }
		public string Konum { get; set; }
	}
}
