namespace RMT_API.DTOs
{
	public class RoleDto
	{
		public int RoleID { get; set; }
		public string? RoleName { get; set; }
		public string? Status { get; set; }
		public DateTime Created_Date { get; set; }
		public int Created_By { get; set; }
		public DateTime? Updated_Date { get; set; }
		public int? Updated_By { get; set; }
	}
}
