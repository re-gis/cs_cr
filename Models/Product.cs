using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApp.Models
{
	public class Product
	{
		public int id { get; set; }
		public string name { get; set; }
		public decimal price { get; set; }
		public string ApplicationUserId { get; set; }
		[ForeignKey("ApplicationUserId")]
		public ApplicationUser ApplicationUser { get; set; }
	}
}