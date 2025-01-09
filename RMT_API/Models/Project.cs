using System.ComponentModel.DataAnnotations;

namespace RMT_API.Models
{
	public class Project
	{
		[Key]
		public int ProjectID { get; set; }

		[Required]
		[StringLength(100)]
		public string? ProjectName { get; set; }

		public int ClientID { get; set; }

		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }

		[StringLength(20)]
		public string? Status { get; set; }

		public DateTime Created_Date { get; set; }
		public int Created_By { get; set; }
		public DateTime? Updated_Date { get; set; }
		public int? Updated_By { get; set; }
	}
}
