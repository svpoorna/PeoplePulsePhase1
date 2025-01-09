namespace RMT_API.DTOs
{
	public class DepartmentDto
	{
		public int DepartmentID { get; set; }
		public string? DepartmentName { get; set; }
		public string? Status { get; set; }
		public DateTime Created_Date { get; set; }
		public int Created_By { get; set; }
		public DateTime? Updated_Date { get; set; }
		public int? Updated_By { get; set; }
	}
}
