﻿using System.ComponentModel.DataAnnotations;

namespace RMT_API.Models
{
	public class Client
	{
		[Key]
		public int ClientID { get; set; }  
		public string? ClientName { get; set; }  
		public string? ContactInfo { get; set; }
		public string? Status { get; set; }
		public DateTime Created_Date { get; set; }
		public int Created_By { get; set; }
		public DateTime? Updated_Date { get; set; } 
		public int? Updated_By { get; set; }
	}
}
