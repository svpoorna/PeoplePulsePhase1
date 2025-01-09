namespace RMT_API.DTOs
{
	public class SupplierDto
	{
		public int SupplierID { get; set; }
		public string? SupplierName { get; set; }
		public string? ContactInfo { get; set; }
		public string? PAN { get; set; }
		public string? GST { get; set; }
		public string? PaymentTerms { get; set; }
		public string? Status { get; set; }
		public DateTime Created_Date { get; set; }
		public int Created_By { get; set; }
		public DateTime? Updated_Date { get; set; }
		public int? Updated_By { get; set; }
	}
}
